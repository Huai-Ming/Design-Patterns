using AdapterPattern.Structure.ObjectAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Class Adapter;
            //ITarget target = new Adapter();
            //target.Request();

            //Object Adapter
            ITarget target = new Adapter();
            target.Request();

            Console.Read();
        }
    }
}
