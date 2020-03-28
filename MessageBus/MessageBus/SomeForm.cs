using System;
using System.Collections.Generic;
using System.Text;
//using System.Windows.Forms

namespace MessageBus
{
    class SomeForm //: Form
    {
        public void OnLoad(EventArgs e) // protected override
        {
            //base.OnLoad(e);
            MessageBus.Instance.Subscribe(this);
            //MessageBus messageBus = new MessageBus();
            //messageBus.Subscribe(this);
        }

        public void OnEvent(OnProgressChangedEvent e)
        {
            //progressBar.Value = e.Progress;
        }

        public void OnClosed(EventArgs e) //protected override 
        {
            //base.OnClosed(e);
            MessageBus.Instance.Unsubscribe(this);
        }
    }
}
