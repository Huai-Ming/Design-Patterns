using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    /// <summary>
    /// Multiple behaviours
    /// </summary>
    public abstract class Observer1
    {
        /// <summary>
        /// Bind the multiple operations to Subject/Publisher
        /// </summary>
        public Observer1(ModelBase childBase)
        {
            childBase.SubEvent += Response;
            childBase.SubEvent += Response1;
        }

        public abstract void Response();

        public abstract void Response1();
    }
}
