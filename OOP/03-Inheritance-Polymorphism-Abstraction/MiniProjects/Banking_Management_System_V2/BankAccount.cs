using System;
using System.Diagnostics.Metrics;

namespace Banking_Management_System_V2
{
    public abstract class BankAccount
    {

        // Class properties

        private string[] _transactionHistory;
        private int _transactionCount;

        private static int _s_nextAccountNumber;
        public string AccountNumber { get; }
        public string AccountName { get; private set; }
        public decimal Balance { get; private set; }

        // Static constructor
        static BankAccount()
        {
            Random random = new Random();
            _s_nextAccountNumber = random.Next(10000000, 20000000);
        }

        // Instance constructor
        public BankAccount(string accountName, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(accountName)) throw new ArgumentNullException(nameof(accountName), "Cannot be empty");

            if (balance < 0) throw new ArgumentException(nameof(balance), "cannot be negative");

            AccountName = accountName;
            Balance = balance;
            AccountNumber = (_s_nextAccountNumber++).ToString("D10");
            _transactionHistory = new string[100];
            _transactionCount = 0;
        }

        // Method to deposit money into account
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero");
                return;
            }

            Balance += amount;

            // Add to history
            AddTransaction($"Deposited: N{amount:F2} | New Balance: N{Balance:F2}");
        }

        // Method to withdraw money from account
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero");
                return;
            }

            Balance -= amount;
        }

        // Method to track transaction history
        protected void AddTransaction(string details)
        {
            // Prevent going out of bounds
            if (_transactionCount >= _transactionHistory.Length)
            {
                Console.WriteLine("History log is full");
                return;
            }

            _transactionHistory[_transactionCount] = details;
            _transactionCount++;
        }

        // Method to show transactions history
        public void ShowTransactionHistory()
        {
            Console.WriteLine("\n--- Transaction History ---");
            for (int i = 0; i < _transactionCount; i++)
            {
                Console.WriteLine($"{i + 1}. {_transactionHistory[i]}");
            }
        }

        // Method to display information of the account
        public abstract void DisplayInfo();
    }
}
