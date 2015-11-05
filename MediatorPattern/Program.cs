using MediatorPattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Colleague colleague1 = new ConcreteColleague1(mediator);
            Colleague colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("Hello, how are you?");
            colleague2.Send("Fine, Thx, and you?");

            Console.Read();
        }
    }
}
