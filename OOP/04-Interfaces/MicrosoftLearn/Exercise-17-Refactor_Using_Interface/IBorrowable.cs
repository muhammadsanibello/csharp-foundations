using System;

namespace Exercise_17_Refactor_Using_Interface
{
    public interface IBorrowable
    {
        bool IsAvailable { get; }
        void Borrow();

    }
}