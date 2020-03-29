using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MessageBus
{    
    class MessageBus
    {
        public static MessageBus Instance { get { return instance ?? (instance = new MessageBus()); } }
        public void Subscribe(object subscriber, string myEvent)
        {
            subscribers.Add(new EventSubscriberWrapper(subscriber, myEvent));
        }
        public void Unsubscribe(object subscriber)
        {
            subscribers.RemoveAll(l => l.Subscriber == subscriber);
        }
        public void Broadcast(object e)
        {
            subscribers.Where(l => l.EventType == e.GetType()).ToList().ForEach(l => l.BroadcastEvent(e));
        }
        
        private static MessageBus instance;
        private MessageBus() { }       
        
        private List<EventSubscriberWrapper> subscribers = new List<EventSubscriberWrapper>(); 

        private class EventSubscriberWrapper 
        {
            public object Subscriber { get; private set; }
            public Type EventType { get; private set; } 
            private MethodBase method; 

            public EventSubscriberWrapper(object subscriber, string myEvent)
            {
                Subscriber = subscriber;                
                Type type = subscriber.GetType(); 
                method = type.GetMethod(myEvent);

                ParameterInfo[] parameters = method.GetParameters();
                EventType = parameters[0].ParameterType;                
            }
            public void BroadcastEvent(object e) 
            {
                method.Invoke(Subscriber, new[] { e });
            }
        }
    }
}
