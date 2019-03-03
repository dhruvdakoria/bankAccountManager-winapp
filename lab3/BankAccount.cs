using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class BankAccount
    {
        private decimal balance,withdraw;
        public BankAccount(decimal initBal)
        {
            withdraw = 0m;
            balance = initBal;
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public void depositFunds(decimal deposit)
        {
             balance += deposit;
        }
        public decimal withdrawFunds
        {
            get { return balance - withdraw;}
            set { withdraw = value; }
        }
    }
}
