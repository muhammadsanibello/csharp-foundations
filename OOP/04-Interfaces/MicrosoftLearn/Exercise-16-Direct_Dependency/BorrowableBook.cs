using System;

namespace Exercise_16_Direct_Dependency
{
    public class BorrowableBook
    {
        public string? Title { get; set; }
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