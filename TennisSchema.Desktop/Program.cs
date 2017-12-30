using TennisSchema.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisSchema
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TennisSchemaGeneratorForm());
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var message = String.Format("An unexpected error occurred during the processing of the request.",
                e.Exception.Message);

            MessageBox.Show(message, "Unexpected Error");
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format("An unexpected error occurred during the processing of the request.",
                ((Exception)e.ExceptionObject).Message);

            MessageBox.Show(message, "Unexpected Error");
        }
    }
}
