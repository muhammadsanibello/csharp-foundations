using System;

namespace Exercise_17_Refactor_Using_Interface
{
    public class BorrowableDVD : IBorrowable
    {
        public string Title { get; set; }
        public bool IsAvailable { get; private set; } = true;

        public BorrowableDVD(string title)
        {
            Title = title;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed the DVD \"{Title}\".");
            }
            else
            {
                Console.WriteLine($"The DVD \"{Title}\" is already borrowed.");
            }
        }
    }
}
