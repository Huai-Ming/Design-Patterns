using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.BookUserLevel
{
    public class DiamondUser:UserLevel
    {
        public DiamondUser(User user) : base(user) { }

        public override double CalculateRealAmount(double amount)
        {
            return amount * 0.7;
        }

        public override void StateCheck()
        {
        }
    }
}
