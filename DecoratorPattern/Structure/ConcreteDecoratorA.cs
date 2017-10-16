using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Structure
{
    public class ConcreteDecoratorA : Decorator
    {
        private string addState;

        public override void Operation()
        {
            base.Operation();
            addState = "New State";
            Console.WriteLine("THe operation of decorator A");
        }

    }
}
