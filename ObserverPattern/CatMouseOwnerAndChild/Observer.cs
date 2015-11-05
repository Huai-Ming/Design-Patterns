using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    /// <summary>
    /// Single behaviour
    /// </summary>
    public abstract class Observer
    {
        /// <summary>
        /// Bind the subject and observer, finish the operation of Subscription.
        /// </summary>
        /// <param name="childBase"></param>
        public Observer(ModelBase childBase) 
        {
            childBase.SubEvent += Response;
            //childBase.SubEvent += new ModelBase.SubEventHandler(Response);
        }

        public abstract void Response();
    }
}
