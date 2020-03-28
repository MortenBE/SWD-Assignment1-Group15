using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    class Worker
    {
        public int Age;
        public int Rank;

        public Worker(int age, int rank)
        {
            Age = age;
            Rank = rank;            
        }

        public void OnEvent(OnProgressChangedEvent e)
        {

            Rank += e.Progress;
        }

        //public void OnEvent(OnAgeChangedEvent e)
        //{
        //    Age += e.Age;
        //}
    }
}
