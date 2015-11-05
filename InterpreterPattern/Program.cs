using InterpreterPattern.Structure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();

            ArrayList list = new ArrayList();

            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach(AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadLine();
        }
    }
}
