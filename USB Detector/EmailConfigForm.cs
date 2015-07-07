using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            EmailConfigFormValidation validationInfo = Validation();
            
            if (validationInfo.isValid)
            {
                // Temporary value for the smtp port parser
                int smtpPort;

                // Load the values into the email configuration instance
                // Email info
                Program.EmailConfiguration.EmailFrom = txtEmailFrom.Text;
                Program.EmailConfiguration.EmailTo = txtEmailTo.Text;
                if (string.IsNullOrWhiteSpace(txtEmailSubject.Text))
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
                Program.EmailConfiguration.WriteToConfigFile();

                // Switch back to the main window
                this.Close();
            }
            else
            {
                String errors = String.Concat(validationInfo.errors);
                MessageBox.Show(errors, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validates input fields
        private EmailConfigFormValidation Validation()
        {
            bool valid = true; // assume it is valid
            List<string> errors = new List<string>();

            #region Empty Text
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