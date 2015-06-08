using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USB_Detector
{
    class EmailConfig
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }

        public EmailConfig()
        {
            // sets helpful defaults
            this.EmailSubject = "Alert from USB Detector";
            this.SmtpPort = 25;
        }

        // Checks for a config file. If it exists, it loads the values
        // into the class and returns true.
        public bool HasConfigFile()
        {
            // TODO: Implement configuration file saving and fetching

            return false;
        }

        public void WriteToConfigFile()
        {
            // TODO: on method invoking, write the properties to the configuration file
        }
    }
}
