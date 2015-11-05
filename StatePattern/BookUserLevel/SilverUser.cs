using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.BookUserLevel
{
    public class SilverUser: UserLevel
    {
        public SilverUser(User user):base(user)
        { }

        public override double CalculateRealAmount(double amount)
        {
            return amount * 0.9;
        }

        public override void StateCheck()
        {
            if (user.PaidMoney > 2000)
            {
                user.UserLevel = new GoldUser(user);
            }
        }
    }
}
