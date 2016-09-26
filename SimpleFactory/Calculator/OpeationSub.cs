using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public class OpeationSub :Operation
    {
        public override double GetResult()
        {
            return base.NumberA - NumberB;
        } 
    }
}
