using System;
using System.Windows.Forms;
using System.Threading;

namespace WFHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            using (var sem = new Semaphore(1, 1, "WFHelper"))
            {
                if (sem.WaitOne(TimeSpan.FromSeconds(1)))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }                
            }
        }
    }
}



