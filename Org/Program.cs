using Org.Common.Repositories;
using Org.Services;
using System;
using System.Windows.Forms;

namespace Org
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new OrgContext();
            var updateService = UpdateService.GetService();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(context, updateService));
        }
    }
}
