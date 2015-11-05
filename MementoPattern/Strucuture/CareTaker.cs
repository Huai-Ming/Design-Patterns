using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Strucuture
{
    public class CareTaker
    {
        private Memento memento;

        public Memento Memento
        {
            set;
            get;
        }
    }
}
