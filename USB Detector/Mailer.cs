using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace USB_Detector
{
    class Mailer
    {
        public string[] SendMail(String message)
        {
            // ["0"] == success. Else ["1", "Failure message"]
            string[] result = new []{"0"};

            try
            {
                // Initialize the message
                MailMessage mail = new MailMessage(Program.EmailConfiguration.EmailFrom, Program.EmailConfiguration.EmailTo, Program.EmailConfiguration.EmailSubject, message);
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            
                // Initialize the client
                SmtpClient client = new SmtpClient(Program.EmailConfiguration.SmtpServer, Program.EmailConfiguration.SmtpPort);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = Program.EmailConfiguration.SmtpSsl;
                client.Timeout = 10000;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(Program.EmailConfiguration.SmtpUsername, Program.EmailConfiguration.SmtpPassword);

                // Send the message
                client.Send(mail);
            }
            catch (Exception e)
            {
                result = new[] {"1", e.Message};
                // TODO: Output a message to the main screen on errors
            }

            return result;
        }
    }
}

// TODO: If internet not available, save in queue on local device