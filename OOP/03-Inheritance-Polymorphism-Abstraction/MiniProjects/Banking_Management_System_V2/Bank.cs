using System;
using System.Data.SqlTypes;

namespace Banking_Management_System_V2
{
    public class Bank
    {
        // Initialize Bank with Name and Location attributes
        public string BankName { get; private set; }
        public string BankLocation { get; private set; }

        private BankAccount[] Accounts;
        private int _maxNumberOfAccounts;
        private int _accountCount;

        // Constructor
        public Bank(string name, string location, int maximumAccounts)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name), "Cannot be empty");

            if (string.IsNullOrWhiteSpace(location)) throw new ArgumentNullException(nameof(location), "Cannot be empty");

            if (maximumAccounts < 1000) throw new ArgumentException(nameof(maximumAccounts), "Cannot be less than 1000");

            BankName = name;
            BankLocation = location;
            _maxNumberOfAccounts = maximumAccounts;
            Accounts = new BankAccount[_maxNumberOfAccounts];
            _accountCount = 0;

        }

        // Method to add account into a Bank
        public void AddAccount(BankAccount account)
        {
            // Prevent going out of bounds
            if (_accountCount >= _maxNumberOfAccounts)
            {
                Console.WriteLine("Bank limit reached");
                return;
            }

            if (SearchAccount(account.AccountNumber))
            {
                Console.WriteLine("Account already exist");
                return;
            }

            Accounts[_accountCount] = account;
            _accountCount++;
        }

        // Method to remove account from a Bank
        public void RemoveAccount(string accountNumber)
        {
            for (int i = 0; i < _accountCount; i++)
            {
                if (Accounts[i].AccountNumber == accountNumber)
                {
                    // Shift everything left by one
                    for (int j = i; j < _accountCount - 1; j++)
                    {
                        Accounts[j] = Accounts[j + 1];
                    }

                    // Clear the last slot
                    Accounts[_accountCount - 1] = null;

                    // Decrement the counter
                    _accountCount--;

                    break;
                }
            }
        }

        // Method to search an account using account number
        public bool SearchAccount(string accountNumber)
        {
            for (int i = 0; i < _accountCount; i++)
            {
                if (Accounts[i].AccountNumber == accountNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public void DisplayAllAccounts()
        {
            for (int i = 0; i < _accountCount; i++)
            {
                Accounts[i].DisplayInfo();
            }
        }
    }
}
