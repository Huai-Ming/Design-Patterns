using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Stucture
{
    public class ConcreteObserver : Observer
    {
        public string ObserverState { get; set; }
        private string name;
        public ConcreteSubject ConcreteSubject { get; set; }

        public ConcreteObserver(ConcreteSubject concreteSubject, string name)
        {
            this.ConcreteSubject = concreteSubject;
            this.name = name;
        }

        public override void Update()
        {
            this.ObserverState = ConcreteSubject.SubjectState;
            Console.WriteLine("The observer's state of {0} is {1}",name,ObserverState);
        }

    }
}
