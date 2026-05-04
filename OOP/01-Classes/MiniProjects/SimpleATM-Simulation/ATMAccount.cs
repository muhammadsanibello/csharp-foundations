using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SimpleATM_Simulation
{
    public class ATMAccount
    {
        public string AccountName;
        public string Pin;
        public double Balance;

        public ATMAccount(string accountName, string pin, double balance)
        {

            AccountName = accountName;
            Pin = pin;
            Balance = balance;

        }

        public void DisplayAccountName()
        {
            Console.WriteLine($"Account user:\nName: {AccountName}.");
        }

        public void CheckBalance(string pin)
        {
            if (Pin != pin)
            {
                Console.WriteLine("Incorrect pin!");
                return;
            }

            Console.WriteLine($"Available Balance: N{Balance:N2}");
        }

        public void Withdraw(string pin, double amount)
        {
            if (Pin != pin)
            {
                Console.WriteLine("Incorrect pin!");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance!");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"You have successfully withdraw N{amount}. Aavilable balance: N{Balance:N2}");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }

            Balance += amount;
            Console.WriteLine($"You have successfully deposited N{amount}. Available balance: N{Balance:N2}");
        }
    }
}
