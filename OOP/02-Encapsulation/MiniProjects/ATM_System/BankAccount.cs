using System;

namespace ATM_System
{
    public class BankAccount
    {

        private static int s_nextAccountNumber;
        private string Pin;

        public int AccountNumber { get; }
        public decimal Balance { get; private set; }
        public string AccountType { get; private set; }

        // Static constructor
        static BankAccount()
        {
            Random random = new Random();
            s_nextAccountNumber = random.Next(1000000000, 2000000000);
        }

        // Constructor
        public BankAccount(decimal balance, string pin, string accountType)
        {
            this.AccountNumber = s_nextAccountNumber++;
            Balance = balance;
            Pin = pin;
            AccountType = accountType;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount! Must be greater than 0");
                return;
            }

            Balance += amount;
        }

        public bool Withdraw(decimal amount, string pin)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount! Must be greater than 0");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }

            if (Pin != pin)
            {
                Console.WriteLine("Invalid Pin!");
                return false;
            }

            Balance -= amount;
            return true;
        }

        public bool Transfer(BankAccount targetAccount, decimal amount, string pin)
        {
            if (Withdraw(amount, pin))
            {
                targetAccount.Deposit(amount);
                return true;
            }

            return false;
        }

        public void CheckBalance(string pin)
        {
            if (Pin != pin)
            {
                Console.WriteLine("Invalid pin!");
                return;
            }

            Console.WriteLine($"Balance: {Balance}");
        }

        public void ChangePin(string oldPin, string newPin)
        {
            if (Pin != oldPin)
            {
                Console.WriteLine("Invalid pin! Pin does not match");
                return;
            }

            if (newPin.Length != Pin.Length)
            {
                Console.WriteLine("Invalid! Length must match");
                return;
            }

            Pin = newPin;
            Console.WriteLine("Pin updated successfully.");
        }

        public void ChangeAccountType(string newType, string pin)
        {
            if (AccountType == newType)
            {
                Console.WriteLine("Already exist");
                return;
            }

            if (Pin != pin)
            {
                Console.WriteLine("Invalid pin!");
                return;
            }

            AccountType = newType;
            Console.WriteLine("Account type updated successfully");
        }

        public string DisplayAccountInfo()
        {
            return $"Account Number # {AccountNumber}, Balance: {Balance}, Type: {AccountType}";
        }
    }
}
