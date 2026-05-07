using System;

namespace Wallet_Expense_Tracker
{
    public class Wallet
    {

        public decimal Balance { get; private set; }
        public decimal Income { get; private set; }
        public decimal Expenses { get; private set; }

        public Wallet()
        {
            Balance = 0;
            Income = 0;
            Expenses = 0;
        }

        public void AddMoney(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount! must be greater than 0.");
                return;
            }

            Income += amount;
            Balance += amount;
        }

        public void RemoveMoney(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount! must be greater than 0.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance!");
                return;
            }

            Expenses += amount;
            Balance -= amount;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Available Balance: {Balance}");
        }

        public string Summary()
        {
            return $"Total Income: {Income}, Total Expenses: {Expenses}, Available Balance: {Balance}";
        }
    }
}
