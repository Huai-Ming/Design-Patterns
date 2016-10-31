using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.Structure
{
    [Serializable]
    public abstract class Prototype
    {
        private string attr;

        public string Attr
        {
            get { return attr; }
            set { attr = value; }
        }

        public abstract Prototype Clone();
    }
}
