using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Structure
{
    public class ConcreteComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Object Operation");
        }
    }
}
