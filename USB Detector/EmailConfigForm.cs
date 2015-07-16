using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            EmailConfigFormValidation validationInfo = ConfigFormValidation();
            
            if (validationInfo.isValid)
            {
                // Temporary value for the smtp port parser
                int smtpPort;

                // Load the values into the email configuration instance
                // Email info
                Program.EmailConfiguration.EmailFrom = txtEmailFrom.Text;
                Program.EmailConfiguration.EmailTo = txtEmailTo.Text;
                if (!string.IsNullOrWhiteSpace(txtEmailSubject.Text))
                {
                    Program.EmailConfiguration.EmailSubject = txtEmailSubject.Text;
                }
                // SMTP info
                if (Int32.TryParse(txtSmtpPort.Text, out smtpPort))
                {
                    Program.EmailConfiguration.SmtpPort = smtpPort;
                }
                Program.EmailConfiguration.SmtpServer = txtSmtpServer.Text;
                Program.EmailConfiguration.SmtpUsername = txtSmtpUser.Text;
                Program.EmailConfiguration.SmtpPassword = txtSmtpPasswd.Text;
                Program.EmailConfiguration.SmtpSsl = chkSslEnabled.Checked;

                // Write the configuration to the configuration file
                WriteToConfigFile();

                // Switch back to the main window
                this.Close();
            }
            else
            {
                String errors = String.Concat(validationInfo.errors);
                MessageBox.Show(errors, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Checks for a config file.
        public bool HasValidConfigFile()
        {
            bool isValid = false;
            string configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "USB Detector", "Email Configuration.txt");
            string configTextJson;
            EmailConfig tmpEmailConfig;

            // Check for config file and sets the configuration if it is valid
            if (File.Exists(configFile))
            {
                using (var reader = new StreamReader(configFile))
                {
                    // Read in the values from the configuration file
                    configTextJson = reader.ReadLine(); // should only have one line in the config file

                    // Validate config file contents
                    tmpEmailConfig = JsonConvert.DeserializeObject<EmailConfig>(configTextJson);
                    txtEmailFrom.Text = tmpEmailConfig.EmailFrom;
                    txtEmailTo.Text = tmpEmailConfig.EmailTo;
                    txtEmailSubject.Text = tmpEmailConfig.EmailSubject;
                    txtSmtpServer.Text = tmpEmailConfig.SmtpServer;
                    txtSmtpPort.Text = tmpEmailConfig.SmtpPort.ToString();
                    txtSmtpUser.Text = tmpEmailConfig.SmtpUsername;
                    txtSmtpPasswd.Text = tmpEmailConfig.SmtpPassword;

                    EmailConfigFormValidation validation = ConfigFormValidation();

                    if (validation.isValid)
                    {
                        isValid = true;

                        // Set the configuration
                        Program.EmailConfiguration.EmailFrom = tmpEmailConfig.EmailFrom;
                        Program.EmailConfiguration.EmailTo = tmpEmailConfig.EmailTo;
                        Program.EmailConfiguration.EmailSubject = tmpEmailConfig.EmailSubject;
                        Program.EmailConfiguration.SmtpServer = tmpEmailConfig.SmtpServer;
                        Program.EmailConfiguration.SmtpPort = tmpEmailConfig.SmtpPort;
                        Program.EmailConfiguration.SmtpUsername = tmpEmailConfig.SmtpUsername;
                        Program.EmailConfiguration.SmtpPassword = tmpEmailConfig.SmtpPassword;
                    }
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
    }
}


// TODO: throw errors to main screen without crashing.
// TODO: Instead of validating empty strings, simply use a try catch and send an error to the screen when the email does not send (already in place)