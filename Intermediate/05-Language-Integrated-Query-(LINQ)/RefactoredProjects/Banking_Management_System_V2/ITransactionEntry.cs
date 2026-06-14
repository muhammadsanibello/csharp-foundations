using System;

namespace Banking_Management_System_V2
{
    public interface ITransactionEntry
    {
        decimal Amount { get; }
        DateTime Date { get; }
    }
}
