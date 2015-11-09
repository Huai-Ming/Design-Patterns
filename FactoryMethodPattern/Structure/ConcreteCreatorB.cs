using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Structure
{
    /// <summary>
    /// A concreteCreator class
    /// </summary>
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductB();
        }
    }
}
