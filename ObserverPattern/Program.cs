using ObserverPattern.CatMouseOwnerAndChild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Cat Mouse Owner and child

            Cat cat = new Cat("Tom");

            Observer mouse = new Mouse("Jerry", cat);

            Observer master = new Master(cat);

            Observer1 baby = new Baby(cat);

            cat.Cry();

            Console.Read();
            

            #endregion

        }
    }
}
