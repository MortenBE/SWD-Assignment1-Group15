using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class Player
    {
        void OnDoWork()
        {        
            MessageBus.Instance.PostEvent(new OnProgressChangedEvent(2));
                       
        }


    }
}
