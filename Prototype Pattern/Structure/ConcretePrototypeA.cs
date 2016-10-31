using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.Structure
{
    class Member
    {
        
    }

    class ConcretePrototypeA:Prototype
    {
        public Member Member { get; set; }

        public override Prototype Clone()
        {
            return (ConcretePrototypeA) this.MemberwiseClone();
        }
    }
}
