using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubjectcs _subject;

        public ConcreteObserver(ConcreteSubjectcs subject, string name)
        {
            _name = name;
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}' new state is {1}",
                _name, _observerState);
        }

        public ConcreteSubjectcs Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
