using SingletonPattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single1 = Singleton.GetInstance();
            Singleton single2 = Singleton.GetInstance();

            HungrySingleton single3 = HungrySingleton.GetInstance();
            HungrySingleton single4 = HungrySingleton.GetInstance();

            if(single1 == single2 && single3 == single4)
            {
                Console.WriteLine("OK");
            }
            Console.Read();

        }
    }
}
