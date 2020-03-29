using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class OnRankChangedEvent
    {
        public int Rank { get; private set; }

        public OnRankChangedEvent(int rank)
        {
            Rank = rank; 
        }
    }

}
