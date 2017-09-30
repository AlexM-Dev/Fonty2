using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fonty2
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
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            frmMain f = new frmMain();

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomain_UnhandledException);
            Application.ThreadException += Application_ThreadException;

            Application.Run(new frmMain());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("An error has occurred:\n\n" + e.Exception.Message +
                "\n\nReport to Alex/Ally if possible.", "Fonty2 Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private static void AppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show("An error has occurred:\n\n" + ex.Message +
                "\n\nReport to Alex/Ally if possible.", "Fonty2 Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
