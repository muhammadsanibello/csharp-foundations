using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Banking_Management_System_V2
{
    // An enum for account types
    public enum AccountType
    {
        Savings,
        Current,
        FixedDeposit
    }

    // An enum for transaction type
    public enum TransactionType
    {
        Deposit,
        Withdraw,
        Transfer
    }

    // Method to return account types description
    public static class AccountTypeExtensions
    {
        public static string GetDescription(this AccountType accountType)
        {
            return accountType switch
            {
                AccountType.Savings => "A savings account for individuals.",
                AccountType.Current => "A business account for businesses",
                AccountType.FixedDeposit => "A personal account for savings",
                _ => "Unknown account type"
            };
        }
    }

    // a bank account number struct
    public readonly struct BankAccountNumber
    {
        public string Value { get; }

        public BankAccountNumber(string value)
        {
            if (value is null || value.Length != 10) throw new ArgumentException("Account number must be 10 digit");

            if (!value.All(char.IsDigit)) throw new ArgumentException("Account number must be digits only");

            Value = value;
        }

        public override string ToString() => Value;
    }

    // a record for transaction
    public record Transaction(decimal Amount, DateTime Date, TransactionType transactionType)
    {
        public override string ToString()
        {
            return $"{Date.ToShortDateString()}: {transactionType} - {Amount:C}\n";
        }
    }

    public abstract class BankAccount
    {

        // Class properties

        private List<Transaction> _transactionHistory = new();
        public BankAccountNumber AccountNumber { get; }
        public abstract AccountType AccountType { get; }
        public string AccountName { get; private set; }
        public decimal Balance { get; private set; }


        // Instance constructor
        public BankAccount(BankAccountNumber accountNumber, string accountName, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(accountName)) throw new ArgumentNullException(nameof(accountName), "Cannot be empty");

            if (balance < 0) throw new ArgumentException(nameof(balance), "cannot be negative");

            AccountNumber = accountNumber;
            AccountName = accountName;
            Balance = balance;
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException(nameof(amount), "Must be greater than zero");

            Balance += amount;

            // Add to history
            AddTransaction(amount, TransactionType.Deposit);
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                return false;  // Transaction failed

            Balance -= amount;

            // Add to history
            AddTransaction(-amount, TransactionType.Withdraw);

            return true; // Transaction succeeded
        }

        // Method to transfer money
        public bool Transfer(BankAccount recipient, decimal amount)
        {
            if (Withdraw(amount))
            {
                recipient.Deposit(amount);
                return true;
            }

            return false;
        }

        // Method to add transaction history
        private void AddTransaction(decimal amount, TransactionType transactionType)
        {
            _transactionHistory.Add(new Transaction(amount, DateTime.Now, transactionType));
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
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Account Details:\nAccount Name: {AccountName}\nAccount Number: {AccountNumber}\nAccount Type: {AccountType}\nDescription: {AccountType.GetDescription()}\nAvailable Balance: {Balance}");
            Console.WriteLine();
        }
    }
}
