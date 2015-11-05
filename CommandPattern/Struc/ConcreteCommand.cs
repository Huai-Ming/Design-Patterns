using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Struc
{
    public class ConcreteCommand:Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {
            
        }

        public override void Execute()
        {
            this.receiver.Action();
        }

    }
}
