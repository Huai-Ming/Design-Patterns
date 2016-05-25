using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide
{
    class ActualPrices : IActualPrices
    {
        public string GoldPrice
        {
            get
            {
                // This value should come from a DB typically
                return "100";
            }
        }

        public string SilverPrice
        {
            get
            {
                // This value should come from a DB typically
                return "5";
            }
        }

        public string DollarToRupee
        {
            get
            {
                // This value should come from a DB typically
                return "50";
            }
        }
    }
}
