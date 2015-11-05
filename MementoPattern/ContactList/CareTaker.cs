using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.ContactList
{
    public class CareTaker
    {
        public Dictionary<string, ContactMemento> ContactMementos { set; get; }

        public CareTaker()
        {
            ContactMementos = new Dictionary<string, ContactMemento>();
        }
    }
}
