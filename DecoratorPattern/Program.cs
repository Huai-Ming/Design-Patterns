using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Structure;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;

            decoratorB.Operation();
            Console.Read();
        }
    }
}
