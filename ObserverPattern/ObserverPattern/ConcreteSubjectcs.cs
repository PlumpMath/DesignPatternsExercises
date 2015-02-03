using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class ConcreteSubjectcs : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set 
            {
                if (_subjectState != value)
                {
                    _subjectState = value;
                    Notify();
                }
            }
        }
    }
}
