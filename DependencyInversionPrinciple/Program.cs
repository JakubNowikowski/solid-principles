using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violating DIP 

            MessengerViolatingDIP msg = new MessengerViolatingDIP();

            msg._sms.Content = "sms content";
            msg._mms.Content = "mms content";
            msg._email.Content = "email content";

            msg.SendMessage();

            //Implementing DIP

            List<IMessage> messages = new List<IMessage>();

            messages.Add(new SMS_DIP() { Content = "smsDip content" });
            messages.Add(new MMS_DIP() { Content = "mmsDip content" });
            messages.Add(new Email_DIP() { Content = "emailDip content" });

            MessengerImplementingDIP msgDip = new MessengerImplementingDIP(messages); //to be very losely coupled it should also implement some interface

            msgDip.SendMessage();

            Console.ReadKey();
        }
    }
}
