using System;

namespace Banking_Management_System_V2
{
    public class CurrentAccount : BankAccount
    {
        private static readonly decimal _maxOverdraft = -5000m;
        public override AccountType AccountType => AccountType.Current;

        public CurrentAccount(BankAccountNumber accountNumber, string accountName, decimal balance) : base(accountNumber,accountName, balance)
        {
        }

        // Override Withdraw method from the base class
        public override bool Withdraw(decimal amount)
        {

            if ((Balance - amount) < _maxOverdraft)
            {
                return false;
            }

            return base.Withdraw(amount);
        }
    }
}
