using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Utilities.Request
{
    public class MailSettings
    {
        public string MailUser { get; set; }
        public string MailUserPass { get; set; }
        public string MailServer { get; set; }
        public string MailServerPort { get; set; }
        public bool MailServerSSL { get; set; }
        public bool FlgSendMail { get; set; }
        public string SystemURL { get; set; }
        public string SystemName { get; set; }
    }
}
