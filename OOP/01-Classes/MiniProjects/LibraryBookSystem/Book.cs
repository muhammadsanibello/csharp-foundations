using System;

namespace LibraryBookSystem
{
    public class Book
    {

        public string Title;
        public string Author;
        public bool IsBorrowed;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public void BorrowBook()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed.");
                return;
            }

            IsBorrowed = true;
            Console.WriteLine("\nBook borrowed successfully.");
        }

        public void ReturnBook()
        {
            IsBorrowed = false;
            Console.WriteLine("\nBook returned successfully.");
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($" Book Title: {Title}\n Book Author: {Author}\n Borrowed: {IsBorrowed}");
        }
    }
}
