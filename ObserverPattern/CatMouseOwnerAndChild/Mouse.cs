using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    public class Mouse:Observer
    {
        private string name;
        public Mouse(string name,ModelBase modelbase):base(modelbase)
        {
            this.name = name;
        }

        public override void Response()
        {
            Console.WriteLine(string.Format("{0} Runs...", this.name));
        }
    }
}
