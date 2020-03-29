using System;

namespace MessageBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Tobi = new Owner("Tobi", 82, 10000);
            Worker John = new Worker("John", 30, 5);
            Worker Eva = new Worker("Eva", 48, 8);
            Worker Tim = new Worker("Tim", 18, 1);

            IMessagesbus messagesbus = MessageBus.Instance;
            

            Console.WriteLine(John.ToString());

            messagesbus.Subscribe(John, "OnEvent");
            messagesbus.Subscribe(John, "OnEventAge");

            messagesbus.Broadcast(new OnAgeChangedEvent(100));
            messagesbus.Broadcast(new OnRankChangedEvent(22));

            Console.WriteLine(John.ToString());


            //MessageBus.Instance.Subscribe(John, "OnEvent");
            //MessageBus.Instance.Subscribe(Tobi, "OnEvent");
            //MessageBus.Instance.Subscribe(Eva, "OnEvent");
            //MessageBus.Instance.Subscribe(John, "OnEventAge");

            //Console.WriteLine(Tobi.ToString());
            //Console.WriteLine(John.ToString());
            //Console.WriteLine(Eva.ToString());
            //Console.WriteLine(Tim.ToString());

            //Console.WriteLine("");
            //Console.WriteLine("");

            //MessageBus.Instance.Broadcast(new OnRankChangedEvent(10));
            //MessageBus.Instance.Broadcast(new OnAgeChangedEvent(10));

            //Console.WriteLine(Tobi.ToString());
            //Console.WriteLine(John.ToString());
            //Console.WriteLine(Eva.ToString());
            //Console.WriteLine(Tim.ToString());

            //Console.WriteLine("");
            //Console.WriteLine("");

            //MessageBus.Instance.Unsubscribe(John);

            //MessageBus.Instance.Broadcast(new OnRankChangedEvent(100));
            //MessageBus.Instance.Broadcast(new OnAgeChangedEvent(100));

            //Console.WriteLine(John.ToString());


            //Tobi.PromoteRanks(10);

            //Console.WriteLine(Tobi.ToString());
            //Console.WriteLine(John.ToString());
            //Console.WriteLine(Eva.ToString());
            //Console.WriteLine(Tim.ToString());


            //Tobi.DismissWorker(John);
            //Tobi.HireWorker(Tim);

            //Tobi.PromoteRanks(100);

            //Console.WriteLine("");
            //Console.WriteLine("");

            //Console.WriteLine(Tobi.ToString());
            //Console.WriteLine(John.ToString());
            //Console.WriteLine(Eva.ToString());
            //Console.WriteLine(Tim.ToString());
        }
    }
}
