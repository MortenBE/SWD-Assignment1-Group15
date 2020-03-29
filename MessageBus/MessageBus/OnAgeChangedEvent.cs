using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class OnAgeChangedEvent
    {
        public int Age { get; private set; }

        public OnAgeChangedEvent(int age)
        {
            Age = age; 
        }
    }
}
