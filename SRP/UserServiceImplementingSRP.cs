using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles
{
    class UserServiceImplementingSRP
    {
        private FileLogger fileLogger = new FileLogger();
        public void Add()
        {
            try
            {
                // Database code
            }
            catch (Exception ex)
            {
                fileLogger.Handle(ex.ToString());
            }
        }
    }
}
