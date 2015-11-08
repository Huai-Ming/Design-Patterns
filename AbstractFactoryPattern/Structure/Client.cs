using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Structure
{
    public class Client
    {
        public AbstractProductA productA;

        public AbstractProductB productB;

        public Client(AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void Run()
        {
            productB.Interact(productA);
        }

    }
}
