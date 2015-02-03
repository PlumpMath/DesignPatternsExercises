using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubjectcs s = new ConcreteSubjectcs();
            
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            
            s.SubjectState = "ABC";

            Console.WriteLine("Wpisz wartość do zmiany: ");
            s.SubjectState = Console.ReadLine();
            //s.Notify();

            Console.ReadKey();
        }
    }
}
