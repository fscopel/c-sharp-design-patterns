using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AssociatedPress : ISubject
    {
        readonly List<IObserver> _observers = new();

        public void NotifyObservers()
        {
            foreach (var obs in _observers)
            {
                obs.Update(DateTime.Now.ToLongDateString());
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);   
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
