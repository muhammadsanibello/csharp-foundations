using System;

namespace BankAccountSystem
{
    public class BankAccount
    {
        private static int s_nextAccountNumber;
        public string AccountName = "Unknown";
        public string AccountNumber;
        public double Balance = 0;

        // Static constructor
        static BankAccount()
        {
            Random random = new Random();
            s_nextAccountNumber = random.Next(10000000, 20000000);
        }

        public BankAccount()
        {
            this.AccountNumber = (s_nextAccountNumber++).ToString("D10");
        }

        public BankAccount(string accountName)
        {
            this.AccountNumber = (s_nextAccountNumber++).ToString("D10");
            AccountName = accountName;
        }

        public BankAccount(string accountName, double balance)
        {
            this.AccountNumber = (s_nextAccountNumber++).ToString("D10");
            AccountName = accountName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }

            Balance += amount;
            Console.WriteLine($"You have successfully deposited N{amount}. Current balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"You have successfully withdraw N{amount}. Available  balance: {Balance}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account Name: {AccountName}, Account Number: {AccountNumber}, Account Balance: {Balance}");
        }
    }

}
