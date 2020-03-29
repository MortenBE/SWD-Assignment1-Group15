using System;

namespace MessageBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Tobi = new Owner(82, 10000);
            Worker John = new Worker(30, 5);
            Worker Eva = new Worker(48, 8);
            Worker Tim = new Worker(18, 1);

            MessageBus.Instance.Subscribe(John);
            MessageBus.Instance.Subscribe(Tobi);
            MessageBus.Instance.Subscribe(Eva);

            Console.WriteLine("Tobi - Money: " + Tobi.Money + " Age: " + Tobi.Age);
            Console.WriteLine("John - Rank: " + John.Rank + " Age: " + John.Age);
            Console.WriteLine("Eva  - Rank: " + Eva.Rank + " Age: " + Eva.Age);
            Console.WriteLine("Tim  - Rank: " + Tim.Rank + " Age: " + Tim.Age);

            Console.WriteLine("");
            Console.WriteLine("");

            MessageBus.Instance.Broadcast(new OnRankChangedEvent(10));
            MessageBus.Instance.Broadcast(new OnAgeChangedEvent(10));

            Console.WriteLine("Tobi - Money: " + Tobi.Money + " Age: " + Tobi.Age);
            Console.WriteLine("John - Rank: " + John.Rank + " Age: " + John.Age);
            Console.WriteLine("Eva  - Rank: " + Eva.Rank + " Age: " + Eva.Age);
            Console.WriteLine("Tim  - Rank: " + Tim.Rank + " Age: " + Tim.Age);

            Console.WriteLine("");
            Console.WriteLine("");

            Tobi.PromoteRanks(10);

            Console.WriteLine("Tobi - Money: " + Tobi.Money + " Age: " + Tobi.Age);
            Console.WriteLine("John - Rank: " + John.Rank + " Age: " + John.Age);
            Console.WriteLine("Eva  - Rank: " + Eva.Rank + " Age: " + Eva.Age);
            Console.WriteLine("Tim  - Rank: " + Tim.Rank + " Age: " + Tim.Age);

            Tobi.DismissWorker(John);
            Tobi.HireWorker(Tim);

            Tobi.PromoteRanks(100);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tobi - Money: " + Tobi.Money + " Age: " + Tobi.Age);
            Console.WriteLine("John - Rank: " + John.Rank + " Age: " + John.Age);
            Console.WriteLine("Eva  - Rank: " + Eva.Rank + " Age: " + Eva.Age);
            Console.WriteLine("Tim  - Rank: " + Tim.Rank + " Age: " + Tim.Age);
        }
    }
}
