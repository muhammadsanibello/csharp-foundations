using System;

namespace Banking_Management_System_V2
{
    public sealed class Ledger<TEntry> where TEntry : ITransactionEntry
    {
        private readonly List<TEntry> _entries = new();

        public IReadOnlyList<TEntry> Entries => _entries;

        public void Add(TEntry entry)
        {
            if (entry is null) throw new ArgumentNullException(nameof(entry));

            _entries.Add(entry);
        }

        public decimal Total() => _entries.Sum(e => e.Amount);
    }
}
