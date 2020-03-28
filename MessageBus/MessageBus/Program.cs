using System;

namespace MessageBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!");

            OnProgressChangedEvent myEvent = new OnProgressChangedEvent(5);

            Console.WriteLine(myEvent.Progress);

            Player myPlayer = new Player();

            //myPlayer.OnDoWork();

            Console.WriteLine(myEvent.Progress);




        }
    }
}
