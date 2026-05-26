using System;

namespace Exercise_17_Refactor_Using_Interface
{
    public class Library
    {
        private IBorrowable _item;

        public Library(IBorrowable item) // Dependency is injected here
        {
            _item = item;
        }

        public void BorrowItem()
        {
            _item.Borrow();
        }
    }
}
