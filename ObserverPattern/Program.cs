//using ObserverPattern.CatMouseOwnerAndChild;
using ObserverPattern.Stucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ////Cat Mouse Owner and child

            //Cat cat = new Cat("Tom");

            //Observer mouse = new Mouse("Jerry", cat);

            //Observer master = new Master(cat);

            //Observer1 baby = new Baby(cat);

            //cat.Cry();

            //Console.Read();
            

            #endregion

            #region For observer pattern structure
            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "Observer A"));
            subject.Attach(new ConcreteObserver(subject, "Observer B"));
            subject.Attach(new ConcreteObserver(subject, "Observer C"));

            subject.SubjectState = "Ready";
            subject.Notify();

            #endregion

            Console.Read();

        }
    }
}
