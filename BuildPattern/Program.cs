using BuildPattern.Stuctural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the director
            Director director = new Director();

            // Create two builder
            Builder builderA = new ConcreteBuilder1();
            Builder builderB = new ConcreteBuilder2();

            //Build the product
            director.Construct(builderA);
            Product productA = builderA.GetResult();
            productA.Show();

            director.Construct(builderB);
            Product productB = builderB.GetResult();
            productB.Show();

            Console.Read();
        }
    }
}
