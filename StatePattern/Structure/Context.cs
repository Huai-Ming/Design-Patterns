using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Structure
{
    public class Context
    {
        private State state;
        public State State
        {
            set { this.state = value; }
            get { return state; }
        }

        public Context()
        {
            this.state = new ConcreteStateA(this);
        }
        public void Request()
        {
            state.Handle();
        }
    }   
}
