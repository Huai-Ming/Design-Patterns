using ProxyPattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //For structure test
            Subject proxy = new Proxy();
            proxy.PerformAction();

            Console.Read();
        }
    }
}
