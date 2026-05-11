using System;

namespace Hotel_Reservation_System
{
    public partial class Hotel
    {
        public string HotelName { get; private set; }
        public int MaxNumberOfRooms { get; private set; }

        private Room[] ListOfRooms;
        private int RoomCount;

        public Hotel(string hotelName, int maximumRooms)
        {
            if (string.IsNullOrEmpty(hotelName)) throw new ArgumentNullException("Hotel Name cannot be empty");

            if (maximumRooms <= 0) throw new ArgumentException("Maximum number of rooms must be greater than zero");
            
            HotelName = hotelName;
            MaxNumberOfRooms = maximumRooms;
            ListOfRooms = new Room[MaxNumberOfRooms];
            RoomCount = 0;
        }

    }
}
