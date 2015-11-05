using IteratorPattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate ca = new ConcreteAggregate();

            ca[0] = "test1";
            ca[1] = "test2";
            ca[2] = "test3";

            //Iterator iterator = new ConcreteIterator(ca);

            Iterator iterator = ca.CreateIterator();
            object obj = iterator.First();
            while (!iterator.IsDone()) 
            {
                Console.WriteLine(iterator.CurrentItem().ToString());
                iterator.Next();
            }

            Console.Read();
        }
    }
}
