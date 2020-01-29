using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Email
    {
        public string Content { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email: " + Content);
        }
    }
}
