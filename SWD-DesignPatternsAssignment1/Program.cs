using System;

namespace SWD_DesignPatternsAssignment1
{
    class Program
    {
        static void OnMessageChanged(MessageChangedEventArgs args)
        {
            Console.WriteLine(args.Message);
        }
        static void test(MessageChangedEventArgs args)
        {
            Console.WriteLine(args.Message);
        }
        static void test2(MessageChangedEventArgs args)
        {
            Console.WriteLine("Gider ikke have besked");
        }

        static void Main(string[] args)
        {
            MessageBus.Subscribe<MessageChangedEvent, MessageChangedEventArgs>(OnMessageChanged);
            MessageBus.Subscribe<MessageChangedEvent, MessageChangedEventArgs>(test);
            MessageBus.Subscribe<MessageChangedEvent, MessageChangedEventArgs>(test2);
            MessageBus.Publish<MessageChangedEvent, MessageChangedEventArgs>(new MessageChangedEventArgs{ Message = "Hello world."});
        }
    }
}
