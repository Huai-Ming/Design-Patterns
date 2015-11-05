using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Structure
{
    public class TerminalExpression : AbstractExpression 
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal Interpret()");
        }
    }
}
