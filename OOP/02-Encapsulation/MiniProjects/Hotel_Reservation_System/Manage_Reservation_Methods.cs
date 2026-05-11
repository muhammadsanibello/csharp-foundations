using System;

namespace Hotel_Reservation_System
{
    public partial class Hotel
    {
        // Method to reserve a room
        public void ReserveRoom(Reservation reserve)
        {
            bool searchSuccess = SearchRoom(reserve._room.RoomNumber);
            
            if (!searchSuccess)
            {
                Console.WriteLine("Sorry! Room is not available.");
                return;
            }

            reserve._room.BookRoom();

            RemoveRoom(reserve._room);
            Console.WriteLine("Success! Room booked");
        
        }

        public void CancelReservation(Reservation reserve)
        {
            reserve._room.ReleaseRoom();
            AddRoom(reserve._room);
            Console.WriteLine("Success! Reservation has been cancelled");
        }
    }
}
