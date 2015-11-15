using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Stucture
{
    /// <summary>
    /// Represents the subject object to publish.
    /// </summary>
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
