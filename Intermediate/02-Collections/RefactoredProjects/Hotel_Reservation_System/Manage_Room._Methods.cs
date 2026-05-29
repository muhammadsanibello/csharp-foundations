using System;

namespace Hotel_Reservation_System
{
    public partial class Hotel
    {
        // Method to add a room
        public void AddRoom(Room room)
        {
            _rooms.Add(room.RoomNumber, room);
        }

        // Method to remove a room
        public void RemoveRoom(int roomNumber)
        {
            if (!_rooms.Remove(roomNumber))
            {
                Console.WriteLine("This room is not available");
                return;
            }

            Console.WriteLine("Success! Room removed.");
        }

        // Method to search a room
        public void SearchRoom(int roomNumber)
        {
            if (_rooms.TryGetValue(roomNumber, out Room room))
            {
                room.DisplayRoomInfo();
            }
            else
            {
                Console.WriteLine("Room not found");
            }
        }

        // Method to display available rooms
        public void DisplayAvailableRooms()
        {
            Console.WriteLine("Available Rooms:\n");

            if (_rooms.Count == 0)
            {
                Console.WriteLine("No Room available.");
                return;
            }

            foreach (var room in _rooms)
            {
                if (!room.Value.IsBooked)
                {
                    room.Value.DisplayRoomInfo();
                }
            }
        }
    }
}