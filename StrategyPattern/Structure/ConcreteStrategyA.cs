using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Structure
{
    public class ConcreteStrategyA :Strategy
    {
        public override void AlgorithmImplementation()
        {
            Console.WriteLine("{0} Algorithm implemenation", this.GetType().Name);
        }
    }
}
