using ChainOfResponsibility.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Structure
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();

            h1.SetSuccessor(h2);
            int[] request = { 3,4,10,12,3,7,13 };

            foreach(int i in request)
            {
                h1.HandleRequest(i);
            }

            Console.Read();

        }
    }
}
