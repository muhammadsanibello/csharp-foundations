using System;

namespace Banking_Management_System_V2
{
    public class FixedDepositAccount : BankAccount
    {
        public FixedDepositAccount(string accountName, decimal balance) : base(accountName, balance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Sorry! You cannot make withdrawal at the moment");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Account Details:\nAccount Name: {AccountName}\nAccount Number: {AccountNumber}\nAvailable Balance: {Balance}");
            Console.WriteLine();
        }
    }
}
