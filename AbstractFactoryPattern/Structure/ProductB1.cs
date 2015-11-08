using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Structure
{
    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + productA.GetType().Name);
        }
    }
}
