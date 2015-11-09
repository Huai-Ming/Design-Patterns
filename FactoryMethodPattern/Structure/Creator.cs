using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Structure
{
    /// <summary>
    /// The Creator abstract class
    /// </summary>
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
