using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    class SomeForm //Form?
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MessageBus messageBus = new MessageBus();
            messageBus.Subscribe(this);
        }

        public void OnEvent(OnProgressChangedEvent e)
        {
            progressBar.Value = e.Progress;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            EventBus.Instance.Unregister(this);
        }
    }
}
