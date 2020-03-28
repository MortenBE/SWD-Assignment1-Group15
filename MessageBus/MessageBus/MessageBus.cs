using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

//Overordnede noter:
//En subscriber er mulighvis slet ikke en subscriber men en form for user (subscriber + publisher)

namespace MessageBus
{
    
    class MessageBus
    {
        public static MessageBus Instance { get { return instance ?? (instance = new MessageBus()); } }
        public void Subscribe(object subscriber)
        {
            subscribers.Add(new EventSubscriberWrapper(subscriber));
        }
        public void Unsubscribe(object subscriber)
        {
            subscribers.RemoveAll(l => l.Subscriber == subscriber);
        }
        public void Broadcast(object e)
        {
            subscribers.Where(l => l.EventType == e.GetType()).ToList().ForEach(l => l.PostEvent(e));
        }
        //For at gøre det til en singleton: 
        private static MessageBus instance;
        private MessageBus() { } //Ved ikke om dette er nødvendigt.        
        
        private List<EventSubscriberWrapper> subscribers = new List<EventSubscriberWrapper>(); 

        private class EventSubscriberWrapper 
        {
            public object Subscriber { get; private set; }
            public Type EventType { get; private set; } 
            private MethodBase method; 

            public EventSubscriberWrapper(object subscriber)
            {
                Subscriber = subscriber;                
                Type type = subscriber.GetType(); 
                method = type.GetMethod("OnEvent"); 
                ParameterInfo[] parameters = method.GetParameters();
                EventType = parameters[0].ParameterType;               
            }

            public void PostEvent(object e) 
            {
                method.Invoke(Subscriber, new[] { e });
            }
        }
    }
}
