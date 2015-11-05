using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.BookUserLevel
{
    /// <summary>
    /// Context for state.
    /// </summary>
    public class User
    {
        private UserLevel userLevel;
        private string userName;
        private double paidMoney;

        public double PaidMoney
        {
            set { paidMoney = value; }
            get { return paidMoney; }
        }

        public UserLevel UserLevel
        {
            set
            {
                userLevel = value;
            }
            get
            {
                return userLevel;
            }
        }

        public User(string userName)
        {
            this.userName = userName;
            this.PaidMoney = 0;
            this.UserLevel = new NormalUser(this);
        }

        public void BuyBook(double amount)
        {
            Console.WriteLine(string.Format("Hello {0}, you have paid {1},and your level is {2}",userName,paidMoney,userLevel.GetType().Name));
            double realAmount = userLevel.CalculateRealAmount(amount);
            Console.WriteLine(string.Format("You only paid {0} for this book", realAmount));
            paidMoney += realAmount;
            userLevel.StateCheck();
        }
    }
}
