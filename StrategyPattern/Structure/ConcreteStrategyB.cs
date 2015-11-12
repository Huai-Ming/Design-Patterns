using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Structure
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmImplementation()
        {
            Console.WriteLine("{0} Algorithm Implementaion", this.GetType().Name);
        }
    }
}
