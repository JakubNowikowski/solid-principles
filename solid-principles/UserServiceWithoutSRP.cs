using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles
{
    class UserServiceWithoutSRP
    {
        public void Register(string email, string password)
        {
            try
            {
                // Database code
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }
}
