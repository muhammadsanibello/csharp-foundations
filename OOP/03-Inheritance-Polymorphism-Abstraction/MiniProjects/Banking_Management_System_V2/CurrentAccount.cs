using System;

namespace Banking_Management_System_V2
{
    public class CurrentAccount : BankAccount
    {
        private static decimal _maxOverdraft = -5000;

        public CurrentAccount(string accountName, decimal balance) : base(accountName, balance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero");
                return;
            }

            if ((Balance - amount) < _maxOverdraft)
            {
                Console.WriteLine("Insufficient maximum overdraft");
                return;
            }

            base.Withdraw(amount);

            // Add to history
            AddTransaction($"Withdrew: N{amount} | New Balance: N{Balance:F2}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Account Details:\nAccount Name: {AccountName}\nAccount Number: {AccountNumber}\nAvailable Balance: {Balance}");
            Console.WriteLine();
        }
    }
}
