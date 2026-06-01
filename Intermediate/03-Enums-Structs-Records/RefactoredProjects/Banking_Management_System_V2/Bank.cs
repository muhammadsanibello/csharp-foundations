using System;
using System.Data.SqlTypes;

namespace Banking_Management_System_V2
{
    public class Bank
    {
        // Initialize Bank with Name and Location attributes
        public string BankName { get; private set; }
        public string BankLocation { get; private set; }

        private Dictionary<BankAccountNumber, BankAccount> _accounts;

        // Constructor
        public Bank(string name, string location)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name), "Cannot be empty");

            if (string.IsNullOrWhiteSpace(location)) throw new ArgumentNullException(nameof(location), "Cannot be empty");

            BankName = name;
            BankLocation = location;
            _accounts = new Dictionary<BankAccountNumber, BankAccount>();
        }

        // Method to add account into a Bank
        public void AddAccount(BankAccount account)
        {
            _accounts.Add(account.AccountNumber, account);
        }

        // Method to remove account from a Bank
        public bool RemoveAccount(BankAccountNumber accountNumber)
        {
            return _accounts.Remove(accountNumber);
        }

        // Method to search an account using account number
        public BankAccount SearchAccount(BankAccountNumber accountNumber)
        {
            if (_accounts.TryGetValue(accountNumber, out BankAccount account))
            {
                return account;
            }

            return null;
        }

        public void DisplayAllAccounts()
        {
            Console.WriteLine("--- Available Accounts ---\n");

            if (_accounts.Count == 0)
            {
                Console.WriteLine("No account available.");
                return;
            }

            foreach (var account in _accounts)
            {
                account.Value.DisplayInfo();
            }
        }
    }
}
