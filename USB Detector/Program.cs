#region imports

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace USB_Detector
{
    internal static class Program
    {
        // Forms
        public static Main FormMain;
        public static EmailConfigForm FormEmailConfig;
        public static EmailConfig EmailConfiguration;
        public static Mailer Emailer;
        public static OtherSettingsForm FormOtherSettings;
        public static OtherSettings OtherSettings;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Prepare the forms
            FormEmailConfig = new EmailConfigForm();
            EmailConfiguration = new EmailConfig {EmailSubject = "Alert from USB Detector"}; // Helpful default
            OtherSettings = new OtherSettings
            {
                LogFileLocation =
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "USB Detector",
                        "log.txt"),
                LoggingEnabled = true
            }; // defaults
            FormOtherSettings = new OtherSettingsForm();
            Emailer = new Mailer();
            FormMain = new Main();

            Application.Run(FormMain);
        }
    }
}