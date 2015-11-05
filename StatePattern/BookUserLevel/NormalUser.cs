using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.BookUserLevel
{
    public class NormalUser : UserLevel
    {
        public NormalUser(User user)
            : base(user)
        { }

        public override double CalculateRealAmount(double amount)
        {
            return amount * 0.95;
        }

        public override void StateCheck()
        {
            if (user.PaidMoney > 1000)
            {
                user.UserLevel = new SilverUser(user);
            }
        }
    }
}
