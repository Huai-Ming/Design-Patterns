using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Structure;

namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Setup structure
            ObjectStructure os = new ObjectStructure();
            os.Attach(new ConcreteElementA());
            os.Attach(new ConcreteElementB());

            //Create visitor objects
            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

            //Strucuture accepting visitors
            os.Accept(visitor1);
            os.Accept(visitor2);


            Console.ReadLine();
        }
    }
}
