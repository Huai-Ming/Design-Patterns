using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public class Client
    {
         
        private static void Main(string[] args)
        {
            Operation oper = new Operation();
            oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());

            Console.ReadKey();
        }
    }
}
