using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Bank
{
    public abstract class Command
    {
        protected Account Account { set; get; }

        public Command(Account account)
        {
            this.Account = account;
        }

        public abstract void Execute();
    }
}
