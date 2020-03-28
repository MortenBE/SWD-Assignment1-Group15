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
            Age = age; //Så, når der er sket fremskridt så sættes dette ind i Progress
        }
    }
}
