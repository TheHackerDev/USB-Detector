#region imports

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

#endregion

namespace USB_Detector
{
    public partial class EmailConfigForm : Form
    {
        public EmailConfigForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Temporary value for the smtp port parser
            int smtpPort;

            // Load the values into the email configuration instance

            // Only continue if valid port entered
            if (Int32.TryParse(txtSmtpPort.Text, out smtpPort))
            {
                // The port may have been incorrect before; ensure the text box is back to being not highlighted
                txtSmtpPort.BackColor = SystemColors.Window;

                // SMTP info
                Program.EmailConfiguration.SmtpPort = smtpPort;
                Program.EmailConfiguration.SmtpServer = txtSmtpServer.Text;
                Program.EmailConfiguration.SmtpUsername = txtSmtpUser.Text;
                Program.EmailConfiguration.SmtpPassword = txtSmtpPasswd.Text;
                Program.EmailConfiguration.SmtpSsl = chkSslEnabled.Checked;

                // Email info
                Program.EmailConfiguration.EmailFrom = txtEmailFrom.Text;
                Program.EmailConfiguration.EmailTo = txtEmailTo.Text;
                if (!string.IsNullOrWhiteSpace(txtEmailSubject.Text))
                {
                    Program.EmailConfiguration.EmailSubject = txtEmailSubject.Text;
                }

                // Write the configuration to the configuration file
                WriteToConfigFile();

                // Switch back to the main window
                this.Close();
            }
            else
            {
                // Highlight the incorrect information
                txtSmtpPort.BackColor = Color.Red;

                // Display a message box to the user and do not close the configuration dialogue
                MessageBox.Show("Invalid port entered. Please enter a number.", "Invalid Port", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Checks for a config file and tries to load it in
        public bool CanLoadConfigFile()
        {
            bool isValid = false;
            string configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "USB Detector", "Email Configuration.txt");

            // Check for config file and sets the configuration if it is valid
            if (File.Exists(configFile))
            {
                try
                {
                    using (var reader = new StreamReader(configFile))
                    {
                        // Read in the values from the configuration file
                        string configTextJson = reader.ReadLine(); // should only have one line in the config file
                        Program.EmailConfiguration = JsonConvert.DeserializeObject<EmailConfig>(configTextJson);

                        // Load in the configuration values to the form
                        txtSmtpServer.Text = Program.EmailConfiguration.SmtpServer;
                        txtSmtpPort.Text = Program.EmailConfiguration.SmtpPort.ToString();
                        txtSmtpUser.Text = Program.EmailConfiguration.SmtpUsername;
                        txtSmtpPasswd.Text = Program.EmailConfiguration.SmtpPassword;
                        txtEmailFrom.Text = Program.EmailConfiguration.EmailFrom;
                        txtEmailTo.Text = Program.EmailConfiguration.EmailTo;
                        txtEmailSubject.Text = Program.EmailConfiguration.EmailSubject;

                        // All seems to be well and valid
                        isValid = true;
                    }
                }
                catch (Exception e)
                {
                    // An error occured, don't load the config file
                    isValid = false;
                }
            }

            return isValid;
        }

        public void WriteToConfigFile()
        {
            // Serialize the email configuration
            string jsonConfig = JsonConvert.SerializeObject(Program.EmailConfiguration);

            // Ensure the folder exists in %AppData% before saving
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configFolder = Path.Combine(appDataFolder, "USB Detector");
            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            // Write to the file
            string emailConfigFile = Path.Combine(configFolder, "Email Configuration.txt");
            using (var writer = new StreamWriter(emailConfigFile))
            {
                writer.WriteLine(jsonConfig);
            }
        }

        #region Saved For Future Use

        // Validates input fields
        private EmailConfigFormValidation ConfigFormValidation()
        {
            bool valid = true; // assume it is valid
            List<string> errors = new List<string>();

            #region Empty Text Validation

            if (string.IsNullOrWhiteSpace(txtSmtpServer.Text))
            {
                valid = false;
                errors.Add("SMTP Server cannot be blank.\r\n");
            }
            if (string.IsNullOrWhiteSpace(txtSmtpPort.Text))
            {
                valid = false;
                errors.Add("SMTP Port cannot be blank.\r\n");
            }
            if (string.IsNullOrWhiteSpace(txtSmtpUser.Text))
            {
                valid = false;
                errors.Add("SMTP Username cannot be blank.\r\n");
            }
            if (string.IsNullOrWhiteSpace(txtSmtpPasswd.Text))
            {
                valid = false;
                errors.Add("SMTP Password cannot be blank.\r\n");
            }
            if (string.IsNullOrWhiteSpace(txtEmailTo.Text))
            {
                valid = false;
                errors.Add("Email To address cannot be blank.\r\n");
            }
            if (string.IsNullOrWhiteSpace(txtEmailFrom.Text))
            {
                valid = false;
                errors.Add("Email From address cannot be blank.\r\n");
            }

            #endregion

            // Return validation information
            return new EmailConfigFormValidation(valid, errors);
        }

        // Structure to hold validation information
        private struct EmailConfigFormValidation
        {
            public bool isValid;
            public List<string> errors;

            public EmailConfigFormValidation(bool isValid, List<string> errors)
            {
                this.isValid = isValid;
                this.errors = errors;
            }
        }

        #endregion
    }
}