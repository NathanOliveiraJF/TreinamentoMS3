using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if(_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in _observers)
                o.Update();
        }
    }
}
