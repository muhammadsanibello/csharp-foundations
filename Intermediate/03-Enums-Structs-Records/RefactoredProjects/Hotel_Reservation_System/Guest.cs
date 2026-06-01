using System;

namespace Hotel_Reservation_System
{
    public class Guest
    {
        private static int s_nextGuestID;
        public string GuestId { get; }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

        // Static constructor
        static Guest()
        {
            Random random = new Random();
            s_nextGuestID = random.Next(10000000, 20000000);
        }

        // instance constructor
        public Guest(string firstName, string lastName, string phoneNumber)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException("First Name cannot be empty");

            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException("Last Name cannot be empty");

            if (string.IsNullOrEmpty(phoneNumber)) throw new ArgumentNullException("Phone Number cannot be empty");

            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            GuestId = (s_nextGuestID++).ToString("D10");

        }

        // Method to display Guest information
        public void DisplayGuestInfo()
        {
            Console.WriteLine("Guest Information:\nFirst Name: {0}\nLast Name: {1}\nPhone Number: {2}\nGuest ID: {3}", FirstName, LastName, PhoneNumber, GuestId);
            Console.WriteLine();
        }
    }
}
