using ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSide
{
    class Program
    {
        static void Main(string[] args)
        {
            IActualPrices proxy = new ActualPricesProxy();

            Console.WriteLine("Gold Price: ");
            Console.WriteLine(proxy.GoldPrice);

            Console.WriteLine("Silver Price: ");
            Console.WriteLine(proxy.SilverPrice);

            Console.WriteLine("Dollar to Ruppe Conversion: ");
            Console.WriteLine(proxy.DollarToRupee);

            Console.Read();
        }
    }
}
