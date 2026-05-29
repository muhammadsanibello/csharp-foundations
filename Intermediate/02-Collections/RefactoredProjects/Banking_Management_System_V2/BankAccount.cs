using System;
using System.Diagnostics.Metrics;

namespace Banking_Management_System_V2
{
    public abstract class BankAccount
    {

        // Class properties

        private List<string> _transactionHistory;

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
            _transactionHistory = new List<string>();
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
            _transactionHistory.Add(details);
        }

        // Method to show transactions history
        public void ShowTransactionHistory()
        {
            Console.WriteLine("--- Transaction History ---\n");

            if (_transactionHistory.Count == 0)
            {
                Console.WriteLine("Transaction history is empty");
                return;
            }

            foreach (var transaction in _transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }

        // Method to display information of the account
        public abstract void DisplayInfo();
    }
}
