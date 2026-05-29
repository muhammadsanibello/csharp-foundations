using System;

namespace Hotel_Reservation_System
{
    public partial class Hotel
    {
        // Method to reserve a room
        public void ReserveRoom(Reservation reserve)
        {
            bool reserveSuccess = reserve.Room.BookRoom();

            if (!reserveSuccess)
            {
                Console.WriteLine("Sorry! This room was already booked.");
                return;
            }

            Console.WriteLine("Success! Room booked.");
        }

        public void CancelReservation(Reservation reserve)
        {
            reserve.Room.ReleaseRoom();
            Console.WriteLine("Success! Reservation cancelled.");
        }
    }
}