﻿using System;

namespace MessageBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Tobi = new Owner("Tobi", 82, 10000);
            Worker John = new Worker("John", 30, 5);
            Worker Tim = new Worker("Tim", 18, 1);
                       
            Console.WriteLine("Workers and Owner are created: ");
            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Tim.ToString());

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("All Workers and Owner are now subscribed to messagebus on Age events: ");
            Console.WriteLine("John is now subscribed to messagebus on Rank events: ");
            MessageBus.Instance.Subscribe(John, "OnEventRank");
            MessageBus.Instance.Subscribe(John, "OnEventAge");
            MessageBus.Instance.Subscribe(Tobi, "OnEventAge");
            MessageBus.Instance.Subscribe(Tim, "OnEventAge");

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Messagebus broadcasts Age- and Rank event: ");
            MessageBus.Instance.Broadcast(new OnAgeChangedEvent(2));
            MessageBus.Instance.Broadcast(new OnRankChangedEvent(3));

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Tim.ToString());

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Owner (Tobi) Prometes ranks using the Messagebus");
            Tobi.PromoteRanks(2);

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Tim.ToString());

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Owner (Tobi) Dismiss(/Unsubscribes) John and hire(subscribes) Tim. Tobi prometes ranks: ");            
            Tobi.DismissWorker(John);
            Tobi.HireWorker(Tim, "OnEventRank");
            Tobi.PromoteRanks(10);

            Console.WriteLine(Tobi.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Tim.ToString());

        }
    }
}
