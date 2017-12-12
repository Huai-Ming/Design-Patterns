using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Structure
{
    public class ConcreteClassA:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Implement operation 1 in Concreate class A.");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Implement operation 2 in Concreate class A.");
        }
    }
}
