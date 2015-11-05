using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structure
{
    public class ConcreteMediator : Mediator
    {
        private Colleague colleague1;
        private Colleague colleague2;

        public Colleague Colleague1
        {
            set { colleague1 = value; }
        }

        public Colleague Colleague2
        {
            set { colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if(colleague == colleague1)
            {
                colleague2.Notity(message);
            }
            else
            {
                colleague1.Notity(message);
            }
        }
    }
}
