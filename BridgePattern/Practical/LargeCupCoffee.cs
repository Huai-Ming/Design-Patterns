using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical
{
    public class LargeCupCoffee : Coffee
    {
        public override void Make()
        {
            MakeCoffee makeCoffee = this.MakeCoffee;
            Console.WriteLine("Large Cup");
            MakeCoffee.Make();
        }
    }
}
