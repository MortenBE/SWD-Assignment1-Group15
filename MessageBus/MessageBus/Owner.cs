using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class Owner
    {
        public string Name;
        public int Age;
        public int Money;

        public Owner(string name, int age, int money)
        {
            Name = name;
            Age = age;
            Money = money;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Money: " + Money;
        }

        public void OnEventAge(OnAgeChangedEvent e)
        {
            Age += e.Age;
        }

        #region useMessageBus
        public void PromoteRanks(int ranks)
        {
            MessageBus.Instance.Broadcast(new OnRankChangedEvent(ranks));
        }
        public void DismissWorker(Worker w)
        {
            MessageBus.Instance.Unsubscribe(w);
        }
        public void HireWorker(Worker w, string myEvent)
        {
            MessageBus.Instance.Subscribe(w, myEvent);
        }
        #endregion


    }
}
