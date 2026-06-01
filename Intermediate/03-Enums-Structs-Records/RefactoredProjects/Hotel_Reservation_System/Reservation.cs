using System;

namespace Hotel_Reservation_System
{
    public class Reservation
    {
        private static int s_nextReservationID;
        private readonly string _reservationId;
        private Guest _guest;
        private int _numberOfDays;
        private double _totalCost;

        public Room Room { get; private set; }

        // Static Constructor
        static Reservation()
        {
            Random random = new Random();
            s_nextReservationID = random.Next(10000000, 20000000);
        }

        // Constructor
        public Reservation(Guest guest, Room room, int numberOfDays)
        {
            if (numberOfDays <= 0)
            {
                throw new ArgumentException("Number of days must be greater than zero");
            }

            _reservationId = (s_nextReservationID++).ToString("D10");
            _guest = guest;
            Room = room;
            _numberOfDays = numberOfDays;
            _totalCost = Room.PricePerNight * _numberOfDays;
        }

        // Method to calculate bills
        public string CalculateBills()
        {
            return $"Total Cost: N{_totalCost:F2}";
        }

        // Method to display reservation
        public void DisplayReservation()
        {
            Console.WriteLine("Reservation details:\nReservation ID: {0}\nGuest ID: {1}\nGuest First Name: {2}\nGuest Last Name: {3}\nGuest Phone Number: {4}\nRoom Number: {5}\nRoom Type: {6}\nPrice per Night: {7}\nNumber of Days: {8}\nTotal cost: {9}", _reservationId, _guest.GuestId, _guest.FirstName, _guest.LastName, _guest.PhoneNumber, Room.RoomNumber, Room.RoomType, Room.PricePerNight, _numberOfDays, _totalCost);
            Console.WriteLine();
        }
    }
}