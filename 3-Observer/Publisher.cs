using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Publisher
    {
        private List <Subscriber> _subscribers;

        public Publisher()
        {
            this._subscribers = new List<Subscriber>(); 
        }

        public void addSubscriber(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void removeSubscriber(Subscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void notify()
        {
            this._subscribers.ForEach(x => x.Update());
        }

    }
}
