using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical
{
    public abstract class Coffee
    {
        private MakeCoffee makeCoffee;

        public Coffee()
        {
            makeCoffee = MakeCoffeeSingleton.Instance();
        }

        public MakeCoffee MakeCoffee
        {
            get { return makeCoffee; }
        }

        public abstract void Make();
    }
}
