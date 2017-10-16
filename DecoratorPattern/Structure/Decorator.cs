using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Structure
{
    public abstract class Decorator:Component
    {
        protected Component component;

        public Component Component
        {
            set { component = value; }
            get { return component; }
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }


    }
}
