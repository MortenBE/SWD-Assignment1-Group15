using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBus
{
    public class Owner
    {
        public int Age;
        public int Money;

        public Owner(int age, int money)
        {
            Age = age;
            Money = money;
        }

        public void OnEvent(OnAgeChangedEvent e)
        {
            Age += e.Age;
        }

        public void PromoteRanks(int ranks)
        {
            MessageBus.Instance.Broadcast(new OnProgressChangedEvent(ranks));
        }

        public void DismissWorker(Worker w)
        {
            MessageBus.Instance.Unsubscribe(w);
        }
        public void HireWorker(Worker w)
        {
            MessageBus.Instance.Subscribe(w);
        }


    }
}
