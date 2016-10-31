using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.Structure
{
    public class Client
    {
        static void Main(string[] args)
        {
            //Prototype prototype = new ConcretePrototype();
            //prototype.Attr = "Hello, Prototype Pattern";
            //Prototype copy = prototype.Clone();
            //Console.WriteLine(copy.Attr);

            //ConcretePrototypeA copy;
            //var prototype = new ConcretePrototypeA();
            //copy = (ConcretePrototypeA)prototype.Clone();
            //Console.WriteLine(prototype == copy);
            //Console.WriteLine(prototype.Member == copy.Member);  

            ConcretePrototypeB copy;
            var prototype = new ConcretePrototypeB();
            prototype.Member = new MemberB("Test");
            copy = (ConcretePrototypeB)prototype.Clone();
            Console.WriteLine(prototype == copy);
            Console.WriteLine(prototype.Member == copy.Member);
            Console.WriteLine(prototype.Member.Value == copy.Member.Value);  


            Console.Read();
        }
    }
}
