using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    public class OnchangeEvent : EventArgs
    {

        public int Progress { get; private set; }
    }
    public class System_Billing
    {
        
        public void reg(EventArgs e)
        {
            EventBus.Instance.Register(this);
        }

        public void OnEvent(OnchangeEvent e)
        {
            Console.WriteLine("estest");
        }
    }
}
