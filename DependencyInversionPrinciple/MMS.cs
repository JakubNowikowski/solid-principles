using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class MMS
    {
        public string Content { get; set; }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS: " + Content);
        }
    }
}
