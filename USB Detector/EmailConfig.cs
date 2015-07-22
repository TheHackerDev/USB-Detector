namespace USB_Detector
{
    internal class EmailConfig
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public bool SmtpSsl { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
    }
}