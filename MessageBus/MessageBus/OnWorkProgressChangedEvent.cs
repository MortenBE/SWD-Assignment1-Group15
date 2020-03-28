using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class OnProgressChangedEvent
    {
        public int Progress { get; private set; }

        public OnProgressChangedEvent(int progress)
        {
            Progress = progress; //Så, når der er sket fremskridt så sættes dette ind i Progress
        }
    }

}
