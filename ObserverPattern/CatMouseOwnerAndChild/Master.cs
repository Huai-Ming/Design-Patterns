using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    public class Master : Observer
    {
        public Master(ModelBase modelBase)
            : base(modelBase)
        { }

        public override void Response()
        {
            Console.WriteLine("Master awake...");
        } 
    }
}
