using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.Structure
{
    public class ConcretePrototype:Prototype
    {

        public override Prototype Clone()
        {
            ConcretePrototype prototype = new ConcretePrototype();
            prototype.Attr = this.Attr;
            return prototype;
        }
    }
}
