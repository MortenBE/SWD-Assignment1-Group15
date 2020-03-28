using System;

namespace SWD_DesignPatternsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            IMessageBus<int> bus = new MessageBus<int>();
            bus.Subscribe(); 
        }
    }
}
