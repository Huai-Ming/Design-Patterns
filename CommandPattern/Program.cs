using CommandPattern.Struc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Bank;

namespace CommandPattern
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //Receiver receiver = new Receiver();
            //Command command = new ConcreteCommand(receiver);
            //Invoker invoker = new Invoker();
            //invoker.SetCommand(command);
            //invoker.ExecuteCommand();


            Account account = new Account();

            var commandDepoist = new DepositCommand(account, 5000);

            var invoker = new Bank.Invoker();

            invoker.SetCommand(commandDepoist);
            invoker.ExecuteCommand();

            Console.WriteLine("The current amount of account is:{0}", account.TotalAmount);

            var commandWithdrawal = new WithdrawalCommand(account, 2000);
            invoker.SetCommand(commandWithdrawal);
            invoker.ExecuteCommand();

            Console.WriteLine("The current amount of account is:{0}", account.TotalAmount);

            Console.Read();
        }
    }
}
