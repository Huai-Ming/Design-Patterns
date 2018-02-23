using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Bank
{
    public class DepositCommand:Command
    {
        private decimal amount;
        public DepositCommand(Account account,decimal amount) : base(account)
        {
            this.amount = amount;
        }

        public override void Execute()
        {
            Account.Deposit(amount);
        }
    }
}
