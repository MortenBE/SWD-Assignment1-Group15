using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    interface IMessagesbus
    {
        public void Subscribe(object subscriber, string myEvent)
        {
            
        }
        public void Unsubscribe(object subscriber)
        {
            
        }
        public void Broadcast(object e)
        {   
            
        }
    }
}
