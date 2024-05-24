using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class CheckingAccount:BankAccount
    {
        public double OverdraftLimit { get; set; }

        public CheckingAccount(string accountHolder, double initialBalance, double overdraftLimit) : base(accountHolder, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }
        // Icrease cost in account
        public override void Deposit(double amount)
        {
            Balance += amount;
        }
        // Decrease cost in account
        public override void Withdraw(double amount)
        {
            // check posibility to decrease with Overdraft Limit
            if (amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
            }
            else 
            {
                Console.WriteLine("Overdraft limit exceeded.");
            }
        }

        public override string DisplayAccountInfo()
        {
            return $"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance} $, Overdraft Limit: {OverdraftLimit}";
        }
    }
}
