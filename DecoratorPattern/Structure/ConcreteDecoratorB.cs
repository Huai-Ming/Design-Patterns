using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Structure
{
    public class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("The operation of decorator B");
        }
    }
}
