using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.CatMouseOwnerAndChild
{
    public class Cat: ModelBase
    {
        private string name;
        public Cat(string name) 
        {
            this.name = name;
        }

        public void Cry()
        {
            Console.WriteLine(string.Format("{0} Cry....", this.name));
            this.Notify();
        }
    }
}
