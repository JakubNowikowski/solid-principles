using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class MessengerViolatingDIP
    {
        public SMS _sms { get; set; }
        public MMS _mms { get; set; }
        public Email _email { get; set; }

        public MessengerViolatingDIP()
        {
            _sms = new SMS();
            _mms = new MMS();
            _email = new Email();
        }

        public void SendMessage()
        {
            _sms.SendSMS();
            _mms.SendMMS();
            _email.SendEmail();
        }
    }
}
