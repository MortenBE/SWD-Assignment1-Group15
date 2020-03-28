using System;

namespace SWD_DesignPatternsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {            
            System_Order test = new System_Order();
            EventBus.Instance.Register(test);


                 
        }
    }
}
