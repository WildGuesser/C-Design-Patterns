using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Publisher
    {
        private List<Subscriber> subscribers;

        public Publisher()
        {
            this.subscribers = new List<Subscriber>();
        }

        public void addSubscriber (Subscriber subscriber)
        {
            subscribers.Add(subscriber);    
        }

        public void removeSubscriber(Subscriber subscriber) {
            subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            this.subscribers.ForEach(x => x.Update());
        }
    }
}
