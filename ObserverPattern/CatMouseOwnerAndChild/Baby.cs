using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    public class Baby:Observer1
    {
        public Baby(ModelBase modelBase)
            : base(modelBase)
        { }

        public override void Response()
        {
            Console.WriteLine("Baby awake...");
        }

        public override void Response1()
        {
            Console.WriteLine("Baby cry...");
        }
    }
}
