using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    public class MessageBus <T> : Ibus<T>
    {
        private class _Subscribers
        {
           
            // Måske implementere subscribers som en klasse istedet...
        }
            public void Subscribe(Action handler)
        {
            if (_Subscribers.ContainsKey(typeof(TMessage)))
                {
                    var handlers = _Subscribers[typeof(TMessage)];
                    handlers.Add(handler);
                }
                else
                {
                    var handlers = new List(); handlers.Add(handler); _Subscribers[typeof(TMessage)] = handlers;
                }
        }

        public void Unsubscribe(Action handler)
        {
            throw new NotImplementedException();
        }

        public void Publish(object message)
        {
            throw new NotImplementedException();
        }

        public void Publish(TMessage<T> message)
        {
            throw new NotImplementedException();
        }
    }
}
