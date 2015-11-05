using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Structure
{
    /// <summary>
    /// Ensure a class only has one instance，and provide a global point of access to.
    /// Lazy model
    /// </summary>
    public class Singleton
    {
        // the single object that the gloabl point provide.
        private static Singleton singleton;
        private static object lock_object = new object();

        // The private contrustor makes sure the class cannot be instantiated.
        private Singleton() { }


        /// <summary>
        /// The global point to be provided to access to
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            //if the singleton does not exist
            if (singleton == null) 
            {
               //Lock the current statement lock
                lock(lock_object)
                {
                    if(singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }
            }
            return singleton;
        }
    }
}
