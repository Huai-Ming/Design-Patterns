using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Structure
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmImplementation()
        {
            Console.WriteLine("{0} Algorithm Implementation", this.GetType().Name);
        }
    }
}
