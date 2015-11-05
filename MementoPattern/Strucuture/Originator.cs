using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Strucuture
{
    public class Originator
    {
        private string state;

        public string State
        {
            get 
            {
                return state;
            }
            set
            {
                state = value;
                Console.WriteLine("State ="  + state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }

    }
}
