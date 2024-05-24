using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public abstract class BankAccount
    {
        // used private for setter in cause it is on BankAccount level
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        // used protected for setter in cause it is could be change on children level
        public double Balance { get; protected set; }

        // Static field for all accounts
        private static int _accountNumberSeed = 123000;

        public BankAccount(string accountHolder, double initialBalance)
        {           
            AccountNumber = _accountNumberSeed++; // Static field for all accounts
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract string DisplayAccountInfo();
    }


}
