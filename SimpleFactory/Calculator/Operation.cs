using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Calculator
{
    public class Operation
    {
        public double NumberA { set; get; }

        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
