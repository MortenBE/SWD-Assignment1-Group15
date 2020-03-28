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
            //Jeg udelader at tjekke om subscriber allerede er subscribet. Dette burde være ok i vores eksempel. 
            subscribers.Add(new EventSubscriberWrapper(subscriber));
        }

        public void Unregister(object subscriber)
        {
            subscribers.RemoveAll(l => l.Subscriber == subscriber); //Subscriber er fra EventSubscriberWrapper, Altså objektet
        }

        public void PostEvent(object e)
        {
            subscribers.Where(l => l.EventType == e.GetType()).ToList().ForEach(l => l.PostEvent(e));
        }

        //For at gøre det til en singleton: 
        private static MessageBus instance;
        private MessageBus() { } //Ved ikke om dette er nødvendigt.
        private List<EventSubscriberWrapper> subscribers = new List<EventSubscriberWrapper>(); //Liste med Event-Subscriber Wrappers.

        private class EventSubscriberWrapper //Evt blot en subscriber. Denne wrapper indeholder subscriberen med mere
        {
            public object Subscriber { get; private set; }
            public Type EventType { get; private set; } //Kig på at fjern
            private MethodBase method; //Kig på at fjern sammen med: using System.Reflection; 

            public EventSubscriberWrapper(object subscriber)
            {
                Subscriber = subscriber;
                
                Type type = subscriber.GetType(); //What dis? - !!!Muligt svar: Det må være typen af klasse altså f.eks. 

                method = type.GetMethod("OnEvent"); //What dis? -> Det her er sikkert vigtigt (Tror det har noget at gøre med med en metode hos subscribers  )
                if (method == null) //Vi behøver ikke at bruge exceptions
                    throw new ArgumentException("Class " + type.Name + " does not containt method OnEvent");

                ParameterInfo[] parameters = method.GetParameters(); //What dis? 
                if (parameters.Length != 1)
                    throw new ArgumentException("Method OnEvent of class " + type.Name + " have invalid number of parameters (should be one)");

                EventType = parameters[0].ParameterType; 

                //Okay det ser at vi lige skal kigge det her igennem inden at vi sletter hele what dis koden. 
            }

            public void PostEvent(object e) // What dis?
            {
                method.Invoke(Subscriber, new[] { e });
            }
        }
    }
}
