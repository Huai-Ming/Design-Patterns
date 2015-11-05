using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structure
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        {

        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }

        public override void Notity(string message)
        {
            Console.WriteLine("Colleague 1 gets the message: " + message);
        }

    }
}
