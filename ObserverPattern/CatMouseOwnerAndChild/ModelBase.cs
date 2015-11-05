using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    public abstract class ModelBase
    {
        public ModelBase()
        { }

        /// <summary>
        /// To declare a delegate without return value and parameter;
        /// </summary>
        public delegate void SubEventHandler();

        /// <summary>
        /// To declare a event that bind to the above delegate.
        /// </summary>
        public event SubEventHandler SubEvent;

        /// <summary>
        /// Except the base class, the derived class cannot call this method.
        /// </summary>
        protected void Notify() 
        {
            if(this.SubEvent != null)
            {
                this.SubEvent();
            }
        }
    }
}
