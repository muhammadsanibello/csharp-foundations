using System;

namespace Exercise_16_Direct_Dependency
{
    public class Library
    {
        private BorrowableBook _book;

        public Library(BorrowableBook book)
        {
            _book = book;
        }

        public void BorrowBook()
        {
            if (_book.IsAvailable)
            {
                _book.Borrow();
            }
            else
            {
                Console.WriteLine("The book is not available.");
            }
        }
    }
}
