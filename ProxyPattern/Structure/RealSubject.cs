using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Structure
{
    public class RealSubject : Subject
    {
        public void PerformAction()
        {
            Console.WriteLine("RealSubject action performed.");
        }
    }
}
