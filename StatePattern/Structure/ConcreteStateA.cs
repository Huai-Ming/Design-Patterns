using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Structure
{
    public class ConcreteStateA:State
    {
        public ConcreteStateA(Context context) : base(context) { }

        public override void Handle()
        {
            Console.WriteLine(string.Format("For first request, the state is {0}", this.GetType().Name));
            context.State = new ConcreteStateB(context);
        }
    }
}
