using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Bank
{
    public class Account
    {
        private decimal totalAmount;

        public decimal TotalAmount
        {
            set { this.totalAmount = value; }
            get { return totalAmount; }
        }

        public void Deposit(decimal amount)
        {
            this.totalAmount += amount;
        }

        public void Withdrawal(decimal amount)
        {
            this.totalAmount -= amount;
        }
    }
}
