using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountHolder, double initialBalance, double interestRate) : base(accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }
        // Icrease cost in account
        public override void Deposit(double amount )
        {
            Balance += amount;
        }
        // Decrease cost in account
        public override void Withdraw(double amount)
        {
            // check posibility to decrease
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        // Return beautify info
        public override string DisplayAccountInfo()
        {
            return $"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance} $, Interest Rate: {InterestRate} %";
        }


        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }
    }
}
