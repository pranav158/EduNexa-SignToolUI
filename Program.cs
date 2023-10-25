using System;
using System.Windows.Forms;
using EduNexaSignTool;
using EduNexaSignTool.Properties;

namespace EduNexaSignTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ApplicationExit += Application_ApplicationExit;

            Application.Run(new MainForm());
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
