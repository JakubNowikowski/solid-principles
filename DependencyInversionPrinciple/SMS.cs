using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class SMS
    {
        public string Content { get; set; }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS: " + Content);
        }
    }
}
