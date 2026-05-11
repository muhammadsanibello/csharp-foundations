using System;

namespace Hotel_Reservation_System
{
    public class Reservation
    {
        private static int s_nextReservationID;
        private readonly string ReservationId;
        private Guest _guest;
        public Room _room { get; private set; }

        private int NumberOfDays;
        private double TotalCost;

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

            ReservationId = (s_nextReservationID++).ToString("D10");
            this._guest = guest;
            this._room = room;
            this.NumberOfDays = numberOfDays;
            this.TotalCost = _room.PricePerNight * NumberOfDays;
        }

        // Method to calculate bills
        public string CalculateBills()
        {
            return $"Total Cost: N{TotalCost:F2}";
        }

        // Method to display reservation
        public void DisplayReservation()
        {
            Console.WriteLine("Reservation details:\nReservation ID: {0}\nGuest ID: {1}\nGuest First Name: {2}\nGuest Last Name: {3}\nGuest Phone Number: {4}\nRoom Number: {5}\nRoom Type: {6}\nPrice per Night: {7}\nNumber of Days: {8}\nTotal cost: {9}", ReservationId, _guest.GuestId, _guest.FirstName, _guest.LastName, _guest.PhoneNumber, _room.RoomNumber, _room.RoomType, _room.PricePerNight, NumberOfDays, TotalCost);
            Console.WriteLine();
        }
    }
}
