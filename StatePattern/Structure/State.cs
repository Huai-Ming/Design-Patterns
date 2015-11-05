using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Structure
{
    public abstract class State
    {
        protected Context context;
        public State(Context context)
        {
            this.context = context;
        }

        public abstract void Handle();
    }
}
