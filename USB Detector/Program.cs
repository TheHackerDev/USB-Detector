using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Detector
{
    static class Program
    {
        // Forms
        public static Main FormMain;
        public static EmailConfigForm FormEmailConfig;
        public static EmailConfig EmailConfiguration;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Prepare the forms
            FormMain = new Main();
            FormEmailConfig = new EmailConfigForm();
            EmailConfiguration = new EmailConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormMain);
        }
    }
}
