using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical
{
    public class WhiteCoffee : MakeCoffee
    {
        public override void Make()
        {
            Console.WriteLine("White Coffee.");
        }
    }
}
