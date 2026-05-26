using System;

namespace Exercise_17_Refactor_Using_Interface
{
    public class BorrowableBook : IBorrowable
    {
        public string Title { get; set; }
        public bool IsAvailable { get; private set; } = true;

        public BorrowableBook(string title)
        {
            Title = title;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed \"{Title}\".");
            }
            else
            {
                Console.WriteLine($"\"{Title}\" is already borrowed.");
            }
        }
    }
}