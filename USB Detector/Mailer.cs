#region imports

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

#endregion

namespace USB_Detector
{
    internal class Mailer
    {
        public Dictionary<string, string> SendMail(String message)
        {
            // Success = "1" when successful, "0" when not
            Dictionary<string, string> result = new Dictionary<string, string>()
            {
                {"success", "1"},
                {"message", ""}
            };

            try
            {
                // TODO: Check for other email possibilities (i.e. Email without username and password, if not present)
                // Initialize the message
                MailMessage mail = new MailMessage(Program.EmailConfiguration.EmailFrom,
                    Program.EmailConfiguration.EmailTo, Program.EmailConfiguration.EmailSubject, message);
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                // Initialize the client
                SmtpClient client = new SmtpClient(Program.EmailConfiguration.SmtpServer,
                    Program.EmailConfiguration.SmtpPort);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = Program.EmailConfiguration.SmtpSsl;
                client.Timeout = 10000;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Program.EmailConfiguration.SmtpUsername,
                    Program.EmailConfiguration.SmtpPassword);

                // Send the message
                client.Send(mail);
            }
            catch (Exception e)
            {
                result["success"] = "0";
                result["message"] = e.Message;
            }

            return result;
        }
    }
}