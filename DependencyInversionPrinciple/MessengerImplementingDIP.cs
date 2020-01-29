using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class MessengerImplementingDIP
    {
        private IEnumerable<IMessage> _messages;
        public MessengerImplementingDIP(IEnumerable<IMessage> messages)
        {
            _messages = messages;
        }
        
        public void SendMessage()
        {
            foreach (var message in _messages)
                message.SendMessage();
        }
    }
}
