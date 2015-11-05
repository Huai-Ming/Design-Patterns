using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical
{
    public sealed class MakeCoffeeSingleton
    {
        private static MakeCoffee makeCoffee;

        public MakeCoffeeSingleton()
        {
        }

        public static MakeCoffee MakeCoffee
        {
            set { makeCoffee = value; }
        }

        public static MakeCoffee Instance()
        {
            return makeCoffee;
        }
    }
}
