using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteObserver : IObserver
    {
        private readonly string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            _name = name;
        }
        public void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"O novo estado do Observer {_name} é {_observerState}");
        }

        public ConcreteSubject Subject
        {
            get { return _subject; }
            private set { _subject = value; } 
        }
    }
}
