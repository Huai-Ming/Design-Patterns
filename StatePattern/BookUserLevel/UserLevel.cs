using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.BookUserLevel
{
    /// <summary>
    /// State for User context.
    /// </summary>
    public abstract class UserLevel
    {
        protected User user;
        public UserLevel(User user)
        {
            this.user = user;
        }

        public abstract double CalculateRealAmount(double amount);

        public abstract void StateCheck();

    }
}
