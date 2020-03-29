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

            MessageBus.Instance.Subscribe(John);
            MessageBus.Instance.Subscribe(Tobi);
            MessageBus.Instance.Subscribe(Eva);

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Eva.ToString());
            Console.WriteLine(Tim.ToString());

            Console.WriteLine("");
            Console.WriteLine("");

            MessageBus.Instance.Broadcast(new OnRankChangedEvent(10));
            MessageBus.Instance.Broadcast(new OnAgeChangedEvent(10));

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Eva.ToString());
            Console.WriteLine(Tim.ToString());

            Console.WriteLine("");
            Console.WriteLine("");

            Tobi.PromoteRanks(10);

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Eva.ToString());
            Console.WriteLine(Tim.ToString());



            Tobi.DismissWorker(John);
            Tobi.HireWorker(Tim);

            Tobi.PromoteRanks(100);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Eva.ToString());
            Console.WriteLine(Tim.ToString());
        }
    }
}
