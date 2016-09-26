using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("The divisor cannot be zero");
            }
            else
            {
                return NumberA / NumberB;
            }
        }
    }
}
