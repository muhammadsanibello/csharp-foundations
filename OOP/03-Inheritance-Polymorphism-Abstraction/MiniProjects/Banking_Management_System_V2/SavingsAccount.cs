using System;

namespace Banking_Management_System_V2
{
    public class SavingsAccount : BankAccount
    {

        private static decimal _minimumBalance = 100;

        public SavingsAccount(string accountName, decimal balance) : base(accountName, balance)
        {
            if (balance < _minimumBalance) throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be less than 100");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            if ((Balance - amount) < _minimumBalance)
            {
                Console.WriteLine($"Insufficient minimum balance");
                return;
            }

            base.Withdraw(amount);

            // Add to histroy
            AddTransaction($"Withdrew: N{amount:F2} | New Balance: N{Balance:F2}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Account Details:\nAccount Name: {AccountName}\nAccount Number: {AccountNumber}\nAvailable Balance: {Balance}");
            Console.WriteLine();
        }
    }
}
