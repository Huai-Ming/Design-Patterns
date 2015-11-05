using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Structure
{
    /// <summary>
    /// Ensure a class only has one instance，and provide a global point of access to.
    /// Hungry model
    /// </summary>
    public class HungrySingleton
    {
        private static readonly HungrySingleton singleton = new HungrySingleton();

        /// <summary>
        /// The constructor cannot be instantiated.
        /// </summary>
        private HungrySingleton()
        { }

        public static HungrySingleton GetInstance()
        {
            return singleton;
        }
    }
}
