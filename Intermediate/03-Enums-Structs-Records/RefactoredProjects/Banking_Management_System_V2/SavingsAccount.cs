using System;

namespace Banking_Management_System_V2
{
    public class SavingsAccount : BankAccount
    {

        private static decimal _minimumBalance = 100;
        public override AccountType AccountType => AccountType.Savings;

        public SavingsAccount(BankAccountNumber accountNumber, string accountName, decimal balance) : base(accountNumber, accountName, balance)
        {
            if (balance < _minimumBalance) throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be less than 100");
        }

        // Override withdraw method from the base class
        public override bool Withdraw(decimal amount)
        {
            if ((Balance - amount) < _minimumBalance)
            {
                return false;
            }

            return base.Withdraw(amount);
        }
    }
}
