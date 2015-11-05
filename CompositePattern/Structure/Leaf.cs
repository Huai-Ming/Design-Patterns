using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structure
{
    public class Leaf : Component
    {
        public Leaf(string name):base(name)
        {

        }

        public override void Add(Component c)
        {
            throw new NotImplementedException("Cannot add the compoment!");
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException("Cannot remove the compoment");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth),name);
        }
    }
}
