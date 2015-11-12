using StrategyPattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Strategy strategyA = new ConcreteStrategyA();
            Strategy strategyB = new ConcreteStrategyB();
            Strategy strategyC = new ConcreteStrategyC();

            Context context = new Context(strategyA);
            context.AlgorithmImplement();

            context = new Context(strategyB);
            context.AlgorithmImplement();

            context = new Context(strategyC);
            context.AlgorithmImplement();

            Console.Read();
        }
    }
}
