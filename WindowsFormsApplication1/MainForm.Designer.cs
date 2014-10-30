namespace WFHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subDivisionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.labelCompanyId = new System.Windows.Forms.Label();
            this.companyIDcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCompaniesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelAppletBuilder = new System.Windows.Forms.Button();
            this.buildLogs = new System.Windows.Forms.Button();
            this.CleanBuildDeploy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenJarsFolders = new System.Windows.Forms.Button();
            this.TestFileImport = new System.Windows.Forms.Button();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TomcatPanel = new System.Windows.Forms.Panel();
            this.TomcatLogsButton = new System.Windows.Forms.Button();
            this.TomcatStopButton = new System.Windows.Forms.Button();
            this.TomcatStartButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TomcatLabel = new System.Windows.Forms.Label();
            this.TomcatStatusPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.wfdsCheckBox = new System.Windows.Forms.CheckBox();
            this.webecCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBuilderStop = new System.Windows.Forms.Button();
            this.searchTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.Menu2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.companyIDcontextMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TomcatPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu2
            // 
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.Menu2.Location = new System.Drawing.Point(0, 0);
            this.Menu2.Name = "Menu2";
            this.Menu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu2.Size = new System.Drawing.Size(367, 24);
            this.Menu2.TabIndex = 6;
            this.Menu2.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.preferencesToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subDivisionComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.labelCompanyId);
            this.panel1.Controls.Add(this.CompanyNameComboBox);
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 84);
            this.panel1.TabIndex = 8;
            // 
            // subDivisionComboBox
            // 
            this.subDivisionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subDivisionComboBox.Font = new System.Drawing.Font("Garamond", 11.25F);
            this.subDivisionComboBox.FormattingEnabled = true;
            this.subDivisionComboBox.Location = new System.Drawing.Point(108, 49);
            this.subDivisionComboBox.Name = "subDivisionComboBox";
            this.subDivisionComboBox.Size = new System.Drawing.Size(194, 25);
            this.subDivisionComboBox.TabIndex = 13;
            this.subDivisionComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subDivisionComboBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "SubDivision";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(308, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelCompanyId
            // 
            this.labelCompanyId.AutoSize = true;
            this.labelCompanyId.ContextMenuStrip = this.companyIDcontextMenu;
            this.labelCompanyId.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyId.Location = new System.Drawing.Point(13, 21);
            this.labelCompanyId.Name = "labelCompanyId";
            this.labelCompanyId.Size = new System.Drawing.Size(89, 18);
            this.labelCompanyId.TabIndex = 9;
            this.labelCompanyId.Text = "Company ID";
            this.labelCompanyId.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelCompanyId_MouseDoubleClick);
            // 
            // companyIDcontextMenu
            // 
            this.companyIDcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCompaniesListToolStripMenuItem});
            this.companyIDcontextMenu.Name = "companyIDcontextMenu";
            this.companyIDcontextMenu.Size = new System.Drawing.Size(179, 26);
            // 
            // editCompaniesListToolStripMenuItem
            // 
            this.editCompaniesListToolStripMenuItem.Name = "editCompaniesListToolStripMenuItem";
            this.editCompaniesListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editCompaniesListToolStripMenuItem.Text = "Edit Companies List";
            this.editCompaniesListToolStripMenuItem.Click += new System.EventHandler(this.editCompaniesListToolStripMenuItem_Click);
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyNameComboBox.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(108, 18);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(194, 25);
            this.CompanyNameComboBox.TabIndex = 8;
            this.CompanyNameComboBox.TextChanged += new System.EventHandler(this.CompanyNameComboBox_TextChanged);
            this.CompanyNameComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyNameComboBox_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabelAppletBuilder);
            this.panel2.Controls.Add(this.buildLogs);
            this.panel2.Controls.Add(this.CleanBuildDeploy);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 84);
            this.panel2.TabIndex = 9;
            // 
            // LabelAppletBuilder
            // 
            this.LabelAppletBuilder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LabelAppletBuilder.Enabled = false;
            this.LabelAppletBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelAppletBuilder.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppletBuilder.Location = new System.Drawing.Point(124, 13);
            this.LabelAppletBuilder.Name = "LabelAppletBuilder";
            this.LabelAppletBuilder.Size = new System.Drawing.Size(98, 28);
            this.LabelAppletBuilder.TabIndex = 10;
            this.LabelAppletBuilder.Text = "SL Builder";
            this.LabelAppletBuilder.UseVisualStyleBackColor = true;
            this.LabelAppletBuilder.Click += new System.EventHandler(this.LabelAppletBuilder_Click);
            // 
            // buildLogs
            // 
            this.buildLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buildLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildLogs.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildLogs.Location = new System.Drawing.Point(228, 13);
            this.buildLogs.Name = "buildLogs";
            this.buildLogs.Size = new System.Drawing.Size(99, 28);
            this.buildLogs.TabIndex = 8;
            this.buildLogs.Text = "===>  Logs";
            this.buildLogs.UseVisualStyleBackColor = true;
            this.buildLogs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buildLogs_MouseDown);
            // 
            // CleanBuildDeploy
            // 
            this.CleanBuildDeploy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CleanBuildDeploy.Enabled = false;
            this.CleanBuildDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanBuildDeploy.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanBuildDeploy.Location = new System.Drawing.Point(13, 13);
            this.CleanBuildDeploy.Name = "CleanBuildDeploy";
            this.CleanBuildDeploy.Size = new System.Drawing.Size(104, 28);
            this.CleanBuildDeploy.TabIndex = 6;
            this.CleanBuildDeploy.Text = "WF Builder";
            this.CleanBuildDeploy.UseVisualStyleBackColor = true;
            this.CleanBuildDeploy.Click += new System.EventHandler(this.CleanBuildDeploy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 47);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "...";
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // OpenJarsFolders
            // 
            this.OpenJarsFolders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenJarsFolders.Font = new System.Drawing.Font("Garamond", 12F);
            this.OpenJarsFolders.Location = new System.Drawing.Point(150, 6);
            this.OpenJarsFolders.Name = "OpenJarsFolders";
            this.OpenJarsFolders.Size = new System.Drawing.Size(130, 28);
            this.OpenJarsFolders.TabIndex = 11;
            this.OpenJarsFolders.Text = "Open Jars Folders";
            this.OpenJarsFolders.UseVisualStyleBackColor = true;
            this.OpenJarsFolders.Click += new System.EventHandler(this.OpenJarsFolders_Click);
            // 
            // TestFileImport
            // 
            this.TestFileImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TestFileImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TestFileImport.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestFileImport.Location = new System.Drawing.Point(172, 48);
            this.TestFileImport.Name = "TestFileImport";
            this.TestFileImport.Size = new System.Drawing.Size(135, 28);
            this.TestFileImport.TabIndex = 7;
            this.TestFileImport.Text = "Test File Import ";
            this.TestFileImport.UseVisualStyleBackColor = true;
            this.TestFileImport.Click += new System.EventHandler(this.TestFileImport_Click);
            // 
            // Notify
            // 
            this.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notify.BalloonTipText = "WF Helper";
            this.Notify.BalloonTipTitle = "WF Helper";
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "WF Helper";
            this.Notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyMouseDoubleClick);
            this.Notify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // ContextMenu2
            // 
            this.ContextMenu2.Name = "contextMenuStrip1";
            this.ContextMenu2.Size = new System.Drawing.Size(61, 4);
            this.ContextMenu2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.ContextMenu2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // TomcatPanel
            // 
            this.TomcatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TomcatPanel.Controls.Add(this.TestFileImport);
            this.TomcatPanel.Controls.Add(this.TomcatLogsButton);
            this.TomcatPanel.Controls.Add(this.TomcatStopButton);
            this.TomcatPanel.Controls.Add(this.TomcatStartButton);
            this.TomcatPanel.Controls.Add(this.panel3);
            this.TomcatPanel.Location = new System.Drawing.Point(10, 292);
            this.TomcatPanel.Name = "TomcatPanel";
            this.TomcatPanel.Size = new System.Drawing.Size(343, 86);
            this.TomcatPanel.TabIndex = 12;
            this.TomcatPanel.Visible = false;
            // 
            // TomcatLogsButton
            // 
            this.TomcatLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TomcatLogsButton.Font = new System.Drawing.Font("Garamond", 12F);
            this.TomcatLogsButton.Location = new System.Drawing.Point(228, 9);
            this.TomcatLogsButton.Name = "TomcatLogsButton";
            this.TomcatLogsButton.Size = new System.Drawing.Size(99, 33);
            this.TomcatLogsButton.TabIndex = 3;
            this.TomcatLogsButton.Text = "Tomcat Logs";
            this.TomcatLogsButton.UseVisualStyleBackColor = true;
            this.TomcatLogsButton.Click += new System.EventHandler(this.TomcatLogsButton_Click);
            // 
            // TomcatStopButton
            // 
            this.TomcatStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TomcatStopButton.Font = new System.Drawing.Font("Garamond", 12F);
            this.TomcatStopButton.Location = new System.Drawing.Point(124, 9);
            this.TomcatStopButton.Name = "TomcatStopButton";
            this.TomcatStopButton.Size = new System.Drawing.Size(98, 33);
            this.TomcatStopButton.TabIndex = 2;
            this.TomcatStopButton.Text = "Tomcat Stop";
            this.TomcatStopButton.UseVisualStyleBackColor = true;
            this.TomcatStopButton.Click += new System.EventHandler(this.TomcatStopButton_Click);
            // 
            // TomcatStartButton
            // 
            this.TomcatStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TomcatStartButton.Font = new System.Drawing.Font("Garamond", 12F);
            this.TomcatStartButton.Location = new System.Drawing.Point(13, 9);
            this.TomcatStartButton.Name = "TomcatStartButton";
            this.TomcatStartButton.Size = new System.Drawing.Size(105, 33);
            this.TomcatStartButton.TabIndex = 1;
            this.TomcatStartButton.Text = "Tomcat Start";
            this.TomcatStartButton.UseVisualStyleBackColor = true;
            this.TomcatStartButton.Click += new System.EventHandler(this.TomcatStartButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TomcatLabel);
            this.panel3.Controls.Add(this.TomcatStatusPanel);
            this.panel3.Location = new System.Drawing.Point(13, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 28);
            this.panel3.TabIndex = 14;
            // 
            // TomcatLabel
            // 
            this.TomcatLabel.AutoSize = true;
            this.TomcatLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TomcatLabel.Location = new System.Drawing.Point(6, 5);
            this.TomcatLabel.Name = "TomcatLabel";
            this.TomcatLabel.Size = new System.Drawing.Size(100, 18);
            this.TomcatLabel.TabIndex = 0;
            this.TomcatLabel.Text = "Tomcat Status";
            // 
            // TomcatStatusPanel
            // 
            this.TomcatStatusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TomcatStatusPanel.Location = new System.Drawing.Point(128, 4);
            this.TomcatStatusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TomcatStatusPanel.Name = "TomcatStatusPanel";
            this.TomcatStatusPanel.Size = new System.Drawing.Size(18, 18);
            this.TomcatStatusPanel.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(378, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(590, 301);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // wfdsCheckBox
            // 
            this.wfdsCheckBox.AutoSize = true;
            this.wfdsCheckBox.Location = new System.Drawing.Point(283, 4);
            this.wfdsCheckBox.Name = "wfdsCheckBox";
            this.wfdsCheckBox.Size = new System.Drawing.Size(48, 17);
            this.wfdsCheckBox.TabIndex = 14;
            this.wfdsCheckBox.Text = "wfds";
            this.wfdsCheckBox.UseVisualStyleBackColor = true;
            // 
            // webecCheckBox
            // 
            this.webecCheckBox.AutoSize = true;
            this.webecCheckBox.Location = new System.Drawing.Point(283, 20);
            this.webecCheckBox.Name = "webecCheckBox";
            this.webecCheckBox.Size = new System.Drawing.Size(58, 17);
            this.webecCheckBox.TabIndex = 15;
            this.webecCheckBox.Text = "webec";
            this.webecCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonBuilderStop);
            this.panel4.Controls.Add(this.OpenJarsFolders);
            this.panel4.Controls.Add(this.webecCheckBox);
            this.panel4.Controls.Add(this.wfdsCheckBox);
            this.panel4.Location = new System.Drawing.Point(10, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 42);
            this.panel4.TabIndex = 16;
            // 
            // buttonBuilderStop
            // 
            this.buttonBuilderStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuilderStop.Enabled = false;
            this.buttonBuilderStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuilderStop.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuilderStop.Location = new System.Drawing.Point(13, 6);
            this.buttonBuilderStop.Name = "buttonBuilderStop";
            this.buttonBuilderStop.Size = new System.Drawing.Size(131, 28);
            this.buttonBuilderStop.TabIndex = 16;
            this.buttonBuilderStop.Text = "Stop Builder";
            this.buttonBuilderStop.UseVisualStyleBackColor = true;
            this.buttonBuilderStop.Click += new System.EventHandler(this.buttonBuilderStop_Click);
            // 
            // searchTypeCheckBox
            // 
            this.searchTypeCheckBox.AutoSize = true;
            this.searchTypeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypeCheckBox.Location = new System.Drawing.Point(244, 8);
            this.searchTypeCheckBox.Name = "searchTypeCheckBox";
            this.searchTypeCheckBox.Size = new System.Drawing.Size(112, 16);
            this.searchTypeCheckBox.TabIndex = 17;
            this.searchTypeCheckBox.Text = "Search on Hard Drive";
            this.searchTypeCheckBox.UseVisualStyleBackColor = true;
            this.searchTypeCheckBox.CheckStateChanged += new System.EventHandler(this.searchType_CheckStateChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(367, 272);
            this.Controls.Add(this.searchTypeCheckBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TomcatPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu2;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Web Forms Helper";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.companyIDcontextMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TomcatPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCompanyId;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buildLogs;
        private System.Windows.Forms.Button TestFileImport;
        private System.Windows.Forms.Button CleanBuildDeploy;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip ContextMenu2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;        
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel TomcatPanel;
        private System.Windows.Forms.Label TomcatLabel;
        private System.Windows.Forms.Button TomcatStopButton;
        private System.Windows.Forms.Button TomcatStartButton;
        private System.Windows.Forms.Button TomcatLogsButton;
        private System.Windows.Forms.Panel TomcatStatusPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LabelAppletBuilder;
        private System.Windows.Forms.Button OpenJarsFolders;
        private System.Windows.Forms.ComboBox subDivisionComboBox;
        private System.Windows.Forms.CheckBox wfdsCheckBox;
        private System.Windows.Forms.CheckBox webecCheckBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip companyIDcontextMenu;
        private System.Windows.Forms.ToolStripMenuItem editCompaniesListToolStripMenuItem;
        private System.Windows.Forms.CheckBox searchTypeCheckBox;
        private System.Windows.Forms.Button buttonBuilderStop;
    }
}

