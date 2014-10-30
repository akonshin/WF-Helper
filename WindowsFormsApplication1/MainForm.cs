using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;
using WFHelper.User_Classes;


[assembly: CLSCompliant(true)]
namespace WFHelper
{

    public partial class MainForm : Form
    {
        static int _counter;
        List<string> _companyList;
        readonly FirstLaunch _fl;
        private TestFileImport _f4;
        private HubEditList _f3;
        Process _cleanBuildDeployProcess; // _tomcatPpocess;
        System.Timers.Timer _myTimer, _myTimer2;
        string _hubNameValue, _subDivisionValue;

        enum BuildType
        {
            WebForms,
            ShippingLabels
        };

        delegate void UpdateProgressDelegate(int value);
        delegate void UpdateLabelDelegate(String value);


        public MainForm()
        {
            InitializeComponent();

            _companyList = new List<string>();

            _fl = new FirstLaunch();
            _fl.CreateAndFillFiles();

        }

        private void CleanBuildDeploy_Click(object sender, EventArgs e)
        {
            CleanBuildDeployMethod();
            buttonBuilderStop.Enabled = true;
        }

        public void CleanBuildDeployMethod()
        {
            tomcat_stop();
            _counter = 0;
            _hubNameValue = CompanyNameComboBox.Text;

            _subDivisionValue = subDivisionComboBox.Text;

            ProcessStart(_hubNameValue, _subDivisionValue);

            HubListUpdate(_hubNameValue);

            CompanyNameComboBox.Text = string.Empty;
            subDivisionComboBox.Text = string.Empty;
            RefreshComboBox(_companyList);
            searchTypeCheckBox.CheckState = CheckState.Unchecked;
        }

        public void ShippingLabelAppletGeneratorMethod()
        {
            tomcat_stop();
            _counter = 0;
            _hubNameValue = CompanyNameComboBox.Text;

            HubListUpdate(_hubNameValue);

            ProcessStart2(_hubNameValue);

            CompanyNameComboBox.Text = string.Empty;
            subDivisionComboBox.Text = string.Empty;
            RefreshComboBox(_companyList);
            searchTypeCheckBox.CheckState = CheckState.Unchecked;
        }

        private void ProcessStart2(string x)
        {
            ProcessStartInfo[] psiArray =
                                     { 
                                        new ProcessStartInfo(_fl.WorkingDirectory+"WebBuild.bat"),  
                                        new ProcessStartInfo(_fl.WorkingDirectory+"WebDeploy.bat"), 
                                        new ProcessStartInfo(_fl.WorkingDirectory+"CopyJarFiles.bat")                                 
                                     };

            if (_counter < 3)
            {
                if (_counter == 0)
                {
                    _fl.StreamToFile("WebBuild", "cd C:\\jv\\JLabel2\\builder && webbuild -Dhub=" + x.Trim() + " docViews  >" + _fl.LogsDirectory + "webbuild.log");
                }
                if (_counter == 2)
                {
                    if (!Directory.Exists("\\*.* C:\\tomcat\\webapps\\webec\\implementation\\" + x + "\\")) Directory.CreateDirectory("C:\\tomcat\\webapps\\webec\\implementation\\" + x + "\\");
                    if (!Directory.Exists("\\*.* C:\\tomcat\\webapps\\wfds\\xtencils\\" + x + "\\")) Directory.CreateDirectory("C:\\tomcat\\webapps\\wfds\\xtencils\\" + x + "\\");

                    _fl.StreamToFile("CopyJarFiles", "copy C:\\jv\\JLabel2\\builder\\target\\client\\docViews\\" + x + "\\*.* C:\\tomcat\\webapps\\webec\\implementation\\" + x + "\\ && copy C:\\jv\\JLabel2\\builder\\target\\client\\docViews\\" + x + "\\*.* C:\\tomcat\\webapps\\wfds\\xtencils\\" + x + "\\");
                    
                }


                psiArray[_counter].UseShellExecute = false;
                psiArray[_counter].CreateNoWindow = true;

                _cleanBuildDeployProcess = new Process { StartInfo = psiArray[_counter] };
                _cleanBuildDeployProcess.Start();


                _counter++;

                _myTimer2 = new System.Timers.Timer();
                _myTimer2.Elapsed += myTimer2_Elapsed;
                _myTimer2.Interval = 1000;
                _myTimer2.Start();

                int leftBound = _cleanBuildDeployProcess.StartInfo.FileName.LastIndexOf("\\", StringComparison.CurrentCulture);
                int rigthBound = _cleanBuildDeployProcess.StartInfo.FileName.LastIndexOf(".bat", StringComparison.CurrentCulture);

                progressBar1.Invoke(new UpdateProgressDelegate(UpdateProgressSafe), _counter);
                progressBar1.Invoke(new UpdateLabelDelegate(UpdateLabelSafe), _cleanBuildDeployProcess.StartInfo.FileName.Substring(leftBound + 1, rigthBound - leftBound));


            }
        }

        private void myTimer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!_cleanBuildDeployProcess.HasExited) return;

            _myTimer2.Stop();

            if (_counter < 3)
            {
                ProcessStart2(_hubNameValue);
            }
            else
            {
                progressBar1.Invoke(new UpdateLabelDelegate(UpdateLabelSafe), IsBuildOk(BuildType.ShippingLabels));
                tomcat_start();
            }
        }

        public void RefreshComboBox(IEnumerable<String> list)
        {
            CompanyNameComboBox.Items.Clear();
            // ReSharper disable CoVariantArrayConversion
            if (list != null) CompanyNameComboBox.Items.AddRange(list.Distinct().ToArray());
            // ReSharper restore CoVariantArrayConversion           
        }

        public void RefreshComboBox()
        {
            CompanyNameComboBox.Items.Clear();
            // ReSharper disable CoVariantArrayConversion
            if (_companyList != null) CompanyNameComboBox.Items.AddRange(_companyList.Distinct().ToArray());
            // ReSharper restore CoVariantArrayConversion            
        }

        private void CompanyNameComboBox_TextChanged(object sender, EventArgs e)
        {
            if (CompanyNameComboBox.Text.Trim().Length > 0)
            {
                CleanBuildDeploy.Enabled = true;
                LabelAppletBuilder.Enabled = true;
                SubDivisionComboBoxFill();
            }
            else
            {
                CleanBuildDeploy.Enabled = false;
                LabelAppletBuilder.Enabled = false;
                SubDivisionComboBoxFill();
            }

        }

        private void SubDivisionComboBoxFill()
        {
            var folders = new List<string>();


            try
            {
                subDivisionComboBox.Items.Clear();
                folders.AddRange(Directory.GetDirectories("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\"));
                folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");

                if (folders.Count > 0)
                {
                    foreach (string item in folders)
                    {
                        subDivisionComboBox.Items.Add(item.Substring(item.LastIndexOf("\\", StringComparison.CurrentCulture) + 1));
                    }
                }
            }
            catch
            {
                subDivisionComboBox.Items.Clear();
            }

        }

        private void TestFileImport_Click(object sender, EventArgs e)  // Test File Import
        {
            var readOnlyCompanyList = new ReadOnlyCollection<string>(_companyList);

            _f4 = new TestFileImport(readOnlyCompanyList);
            _f4.Show();
        }

        private void ProcessStart(string x, string y)
        {
            ProcessStartInfo[] psiArray =
                                     { 
                                        new ProcessStartInfo(_fl.WorkingDirectory+"Clean.bat"),  
                                        new ProcessStartInfo(_fl.WorkingDirectory+"Build.bat"), 
                                        new ProcessStartInfo(_fl.WorkingDirectory+"Deploy.bat")                                 
                                     };

            if (_counter < 3)
            {
                if (_counter == 1)
                {
                    if (string.IsNullOrEmpty(y.Trim()))
                    {
                        _fl.StreamToFile("Build", "impbuild -Dhub=" + x.Trim() + " WebForms >  " + _fl.LogsDirectory + "build.log");
                    }
                    else
                    {
                        _fl.StreamToFile("Build", "impbuild -Dhub=" + x.Trim() + " " + "-Ddivision=" + y.Trim() + " WebForms >  " + _fl.LogsDirectory + "build.log");
                    }
                }


                psiArray[_counter].UseShellExecute = false;
                psiArray[_counter].CreateNoWindow = true;

                _cleanBuildDeployProcess = new Process { StartInfo = psiArray[_counter] };
                _cleanBuildDeployProcess.Start();


                _counter++;

                _myTimer = new System.Timers.Timer();
                _myTimer.Elapsed += myTimer_Elapsed;
                _myTimer.Interval = 1000;
                _myTimer.Start();

                var leftBound = _cleanBuildDeployProcess.StartInfo.FileName.LastIndexOf("\\", StringComparison.CurrentCulture);
                var rigthBound = _cleanBuildDeployProcess.StartInfo.FileName.LastIndexOf(".bat", StringComparison.CurrentCulture);

                progressBar1.Invoke(new UpdateProgressDelegate(UpdateProgressSafe), _counter);
                progressBar1.Invoke(new UpdateLabelDelegate(UpdateLabelSafe), _cleanBuildDeployProcess.StartInfo.FileName.Substring(leftBound + 1, rigthBound - leftBound));


            }
        }

        private void UpdateProgressSafe(int value)
        {
            progressBar1.Value = value;
        }

        private void UpdateLabelSafe(string value)
        {
            label2.Text = value;
        }

        private void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {            
            if (!_cleanBuildDeployProcess.HasExited) return;

            _myTimer.Stop();

            if (_counter < 3)
            {
                ProcessStart(_hubNameValue, _subDivisionValue);
            }
            else
            {
                progressBar1.Invoke(new UpdateLabelDelegate(UpdateLabelSafe), IsBuildOk(BuildType.WebForms));
                tomcat_start();
            }
        }

        private string IsBuildOk(Enum e)
        {
            try
            {
                string fileContent;
                string fileDeployContent;

                if (e.Equals(BuildType.WebForms))
                {
                    fileContent = File.ReadAllText(_fl.WorkingDirectory + "Logs\\build.log");
                    fileDeployContent = File.ReadAllText(_fl.WorkingDirectory + "Logs\\deploy.log");
                }
                else if (e.Equals(BuildType.ShippingLabels))
                {
                    fileContent = File.ReadAllText(_fl.WorkingDirectory + "Logs\\webbuild.log");
                    fileDeployContent = File.ReadAllText(_fl.WorkingDirectory + "Logs\\webdeploy.log");
                }
                else
                {
                    fileContent = null;
                    fileDeployContent = null;
                }


                if (fileContent != null && fileContent.Contains("BUILD SUCCESSFUL"))
                {
                    var str = String.Empty;
                    try
                    {
                        var startIndex = fileDeployContent.IndexOf("Copying ", StringComparison.Ordinal);
                        str = ", " + fileDeployContent.Substring(startIndex, 15);
                    }
                    catch{}

                    return "Complete" + str;
                }

                return "Complete with Errors";
            }
            catch
            {
                return "Log file is not exists";
            }
        
        }

        private void tomcat_restart()
        {
            tomcat_stop();
            tomcat_start();
        }

        private void tomcat_stop()
        {
            try
            {
                var ps1 = Process.GetProcessesByName("Tomcat6");

                if (ps1.Length > 0)
                {
                    foreach (var p1 in ps1)
                    {
                        p1.Kill();
                    }
                }

                ps1 = Process.GetProcessesByName("Tomcat7");

                if (ps1.Length > 0)
                {
                    foreach (var p1 in ps1)
                    {
                        p1.Kill();
                    }
                }

                TomcatStatusPanel.BackgroundImage = Resources.Resources.RedLabel;
            }

            catch { MessageBox.Show(Resources.Resources.MainForm_tomcat_stop_Having_problems_with_stopping_Tomcat); }
        }

        private void tomcat_start()
        {
            /*
            var fName = string.Empty;
            if (File.Exists("C:\\tomcat\\bin\\Tomcat6.exe"))
            {
                fName = "C:\\tomcat\\bin\\Tomcat6.exe";
            }
            if (File.Exists("C:\\tomcat\\bin\\Tomcat7.exe"))
            {
                fName = "C:\\tomcat\\bin\\Tomcat7.exe";
            }

            _tomcatPpocess = new Process
                {

                    StartInfo =
                        {
                            FileName = fName,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                };

            _tomcatPpocess.OutputDataReceived += TomcatP_OutputDataReceived;


            try
            {
                _tomcatPpocess.Start();
                _tomcatPpocess.BeginOutputReadLine();
                TomcatStatusPanel.BackgroundImage = Resources.Resources.GreenLabel;
            }

            catch
            {
                MessageBox.Show(Resources.Resources.MainForm_tomcat_start_Having_problems_with_starting_Tomcat);
                TomcatStatusPanel.BackgroundImage = Resources.Resources.RedLabel;
            }
             */
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            Serialize();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Deserialize();
            // ReSharper disable CoVariantArrayConversion
            if (_companyList != null) CompanyNameComboBox.Items.AddRange(_companyList.Distinct().ToArray());
            // ReSharper restore CoVariantArrayConversion
        }

        private void Serialize()
        {
            using (var fs = new FileStream(_fl.WorkingDirectory + "file.s", FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                var bf = new BinaryFormatter();

                bf.Serialize(fs, _companyList);
            }

        }

        private void Deserialize()
        {
            try
            {
                using (var fs = new FileStream(_fl.WorkingDirectory + "file.s", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var bf = new BinaryFormatter();

                    _companyList = (List<string>)bf.Deserialize(fs);
                }

            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            // ReSharper restore EmptyGeneralCatchClause
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CompanyNameComboBox.Text)) return;

            folderOpener(@"C:\jv\implementation\maps\", CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text);
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label2.ForeColor = label2.Text.Contains("Errors") ? Color.Red : Color.Black;
        }

        private void CompanyNameComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !String.IsNullOrEmpty(CompanyNameComboBox.Text.Trim()))
            {
                CleanBuildDeploy.Focus();
            }
        }

        private void subDivisionComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !String.IsNullOrEmpty(CompanyNameComboBox.Text.Trim()))
            {
                CleanBuildDeploy.Focus();
            }
        }

        private void TomcatStartButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            tomcat_restart();
        }

        private void TomcatStopButton_Click(object sender, EventArgs e)
        {
            tomcat_stop();
        }

        private void TomcatLogsButton_Click(object sender, EventArgs e)
        {
            Width = Width != 986 ? 986 : 373;
        }

        private void labelCompanyId_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CompanyNameComboBox.SelectedIndex = CompanyNameComboBox.Items.Count - 1;
            CompanyNameComboBox.Focus();
        }

        private void LabelAppletBuilder_Click(object sender, EventArgs e)
        {
            ShippingLabelAppletGeneratorMethod();
        }

        private void OpenJarsFolders_Click(object sender, EventArgs e)
        {
            if (wfdsCheckBox.Checked)
            {
                folderOpener("C:\\tomcat\\webapps\\wfds\\xtencils\\", _companyList.Last());
            }

            if (webecCheckBox.Checked)
            {
                folderOpener("C:\\tomcat\\webapps\\webec\\implementation\\", _companyList.Last());
            }

        }

        private void folderOpener(String s, String ss = "")
        {
            if (Directory.Exists(s + ss))
            {
                Process.Start("explorer", s + ss);
            }
            else
            {
                Process.Start("explorer", s);
            }
        }

        private void editCompaniesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _f3 = new HubEditList(_companyList, this);

            _f3.Show();
        }

        private void searchType_CheckStateChanged(object sender, EventArgs e)
        {
            var globalCompaniesList = new List<String>();
            if (searchTypeCheckBox.CheckState == CheckState.Checked)
            {
                try
                {
                    foreach (var d in Directory.GetDirectories(@"C:\jv\implementation\maps\"))
                    {
                        globalCompaniesList.AddRange(Directory.GetDirectories(d).Distinct().ToList());
                    }
                }
                catch { }
               
                RefreshComboBox(globalCompaniesList.Distinct().Select(n => n.Substring(n.LastIndexOf("\\", StringComparison.CurrentCulture) + 1)));
             
            }
            else
            {
                RefreshComboBox(_companyList);
            }

        }       

        private void buttonBuilderStop_Click(object sender, EventArgs e)
        {
            _cleanBuildDeployProcess.Kill();
            _myTimer.Stop();
            progressBar1.Invoke(new UpdateProgressDelegate(UpdateProgressSafe), 0);
            progressBar1.Invoke(new UpdateLabelDelegate(UpdateLabelSafe), "Process has been stopped");
            buttonBuilderStop.Enabled = false;
        }

       
    }
}
