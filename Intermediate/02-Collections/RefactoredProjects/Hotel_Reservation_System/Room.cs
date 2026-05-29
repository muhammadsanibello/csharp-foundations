using System;

namespace Hotel_Reservation_System
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public string RoomType { get; private set; }
        public double PricePerNight { get; private set; }
        public bool IsBooked { get; private set; }

        // instance constructor
        public Room(int roomNumber, string roomType, double pricePerNight)
        {
            if (roomNumber <= 0) throw new ArgumentException("Room Number must be greater than zero");

            if (string.IsNullOrEmpty(roomType)) throw new ArgumentNullException("Room type cannot be empty");

            if (pricePerNight < 0) throw new ArgumentException("Price cannot be negative");

            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsBooked = false;
        }

        // Method to book a room
        public bool BookRoom()
        {
            if (IsBooked)
            {
                return false;
            }

            IsBooked = true;
            return true;
        }

        // Method to release a room
        public void ReleaseRoom()
        {
            IsBooked = false;
        }

        // Method to display a Room information
        public void DisplayRoomInfo()
        {
            Console.WriteLine("Room Information:\nRoom Number: {0}\nRoom Type: {1}\nPrice Per Night: {2}\nBooking Status: {3}", RoomNumber, RoomType, PricePerNight, IsBooked);
            Console.WriteLine();
        }
    }
}
