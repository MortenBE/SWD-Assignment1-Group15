using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class Worker
    {
        public string Name; 
        public int Age;
        public int Rank;

        public Worker(string name, int age, int rank)
        {
            Name = name;
            Age = age;
            Rank = rank;            
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Rank: " + Rank;
        }

        public void OnEvent(OnRankChangedEvent e)
        {
            Rank += e.Rank;
        }
        public void OnEventAge(OnAgeChangedEvent e)
        {
            Age += e.Age;
        }
    }
}
