using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OpeationSub();
                    break;
                case "*":
                    oper = new OperationMulti();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    throw new Exception("Invlidate Operator");
            }
            return oper;
        }
    }
}
