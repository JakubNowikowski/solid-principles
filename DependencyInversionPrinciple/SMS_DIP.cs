using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class SMS_DIP : IMessage
    {
        public string Content { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Sending sms message: " + Content);
        }
    }
}
