using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.BookUserLevel
{
    public class GoldUser: UserLevel
    {
        public GoldUser(User user):base(user)
        { }

        public override double CalculateRealAmount(double amount)
        {
            return amount * 0.8;
        }

        public override void StateCheck()
        {
            if(user.PaidMoney > 5000)
            {
                user.UserLevel = new DiamondUser(user);
            }
        }
    }
}
