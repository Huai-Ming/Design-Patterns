using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Structure;

namespace TemplateMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractClass c;

            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
