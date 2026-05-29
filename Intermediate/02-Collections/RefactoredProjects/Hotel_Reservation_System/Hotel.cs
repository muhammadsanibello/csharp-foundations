using System;

namespace Hotel_Reservation_System
{
    public partial class Hotel
    {
        public string HotelName { get; private set; }

        private Dictionary<int, Room> _rooms;

        public Hotel(string hotelName)
        {
            if (string.IsNullOrEmpty(hotelName)) throw new ArgumentNullException("Hotel Name cannot be empty");
            
            HotelName = hotelName;
            _rooms = new Dictionary<int, Room>();
        }

    }
}