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
        private bool IsValid = false;

        public EmailConfigForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Temporary value for the smtp port parser
            int smtpPort;

            // Load the values into the email configuration instance
            // Email info
            Program.EmailConfiguration.EmailFrom = txtEmailFrom.Text;
            Program.EmailConfiguration.EmailTo = txtEmailTo.Text;
            if (!txtEmailSubject.Text.Equals(""))
            {
                Program.EmailConfiguration.EmailSubject = txtEmailSubject.Text;
            }
            // SMTP info
            if (Int32.TryParse(txtSmtpPort.Text,out smtpPort))
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

        private void Validate_txtSmtpServer(object sender, EventArgs e)
        {
            string input = e.ToString();

            if (!Program.ConfigValidator.IsValid_TextLength(input))
            {
                IsValid = false;
            }
            else if (!Program.ConfigValidator.IsValid_NotEmpty(input))
            {
                IsValid = false;
            }
        }

        private void txtEmailSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSmtpPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSmtpPasswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/* TODO: Add validation with error fields to the input fields (validate on focus leave)
 *      Text length
 *      Not empty (unless optional) - is username and password always required on SMTP servers?
 *      Valid port (range and is number)
 */