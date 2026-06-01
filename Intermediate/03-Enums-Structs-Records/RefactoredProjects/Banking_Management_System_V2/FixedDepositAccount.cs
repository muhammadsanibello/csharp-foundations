using System;

namespace Banking_Management_System_V2
{
    public class FixedDepositAccount : BankAccount
    {
        public override AccountType AccountType => AccountType.FixedDeposit;
        public FixedDepositAccount(BankAccountNumber accountNumber,string accountName, decimal balance) : base(accountNumber,accountName, balance)
        {
        }

        // Override withdraw method from the base class
        public override bool Withdraw(decimal amount)
        {
            throw new InvalidOperationException("Withdrawal is forbidden at the moment");
        }
    }
}