using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Structure.ObjectAdapter
{
    public class Adapter:ITarget
    {
        private Adaptee adaptee = new Adaptee();
        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
