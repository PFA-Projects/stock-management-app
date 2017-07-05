using GenericWinForm.Demo;
using StockManagement.Presentation.DepartureFiles;
using System;
using System.Windows.Forms;

namespace StockManagement
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
            Application.Run(new FormMenuApplication());
        }
    }
}
