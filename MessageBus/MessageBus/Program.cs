using System;

namespace MessageBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Tobi = new Owner(82, 10000);
            Worker John = new Worker(30, 5);
            Worker Tim = new Worker(18, 1);
            MessageBus.Instance.Subscribe(John);
            MessageBus.Instance.Subscribe(Tobi);

            Console.WriteLine("Tobi - Moeny: " + Tobi.Money + " Age: " + Tobi.Age);
            Console.WriteLine("John - Rank: " + John.Rank + " Age: " + John.Age);
            Console.WriteLine("Tim  - Rank: " + Tim.Rank + " Age: " + Tim.Age);

            Console.WriteLine("");
            Console.WriteLine("");

            MessageBus.Instance.PostEvent(new OnProgressChangedEvent(10));
            MessageBus.Instance.PostEvent(new OnAgeChangedEvent(10));
            Console.WriteLine("Tobi - Moeny: " + Tobi.Money + " Age: " + Tobi.Age);
            Console.WriteLine("John - Rank: " + John.Rank + " Age: " + John.Age);
            Console.WriteLine("Tim  - Rank: " + Tim.Rank + " Age: " + Tim.Age);



            //OnProgressChangedEvent myEvent = new OnProgressChangedEvent(5);

            //Console.WriteLine(myEvent.Progress);

            //Player myPlayer = new Player();

            ////myPlayer.OnDoWork();

            //Console.WriteLine(myEvent.Progress);




        }
    }
}
