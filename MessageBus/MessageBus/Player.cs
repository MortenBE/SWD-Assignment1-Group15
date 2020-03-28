using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    class Player
    {
        void OnDoWork()
        {
            // ...

            MessageBus.Instance.PostEvent(new OnProgressChangedEvent(progress));

            // ...
        }


    }
}
