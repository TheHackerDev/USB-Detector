using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace USB_Detector
{
    class EmailConfig
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public bool SmtpSsl { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }

        public EmailConfig()
        {
            if (HasValidConfigFile())
            {
                // TODO: Load in config file to the class
            }
            else
            {
                // sets helpful defaults
                this.EmailSubject = "Alert from USB Detector";
            }
        }

        // Checks for a config file.
        public bool HasValidConfigFile()
        {
            // TODO: Implement configuration file saving and fetching
            // TODO: Implement validation on the configuration file values, don't load in values if it does not validate

            return false;
        }

        public void WriteToConfigFile()
        {
            // TODO: on method invoking, write the properties to the configuration file
        }
    }
}

