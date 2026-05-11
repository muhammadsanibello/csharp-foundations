using System;

namespace Hotel_Reservation_System
{
    public partial class Hotel
    {
        // Method to add a room
        public void AddRoom(Room room)
        {
            if (RoomCount >= MaxNumberOfRooms)
            {
                Console.WriteLine("Hotel is full");
                return;
            }

            for (int i = 0; i < RoomCount; i++)
            {
                if (ListOfRooms[i].RoomNumber == room.RoomNumber)
                {
                    Console.WriteLine("Sorry! This room already exist.");
                    return;
                }
            }

            ListOfRooms[RoomCount] = room;
            RoomCount++;
        }

        // Method to remove a room
        public void RemoveRoom(Room room)
        {
            for (int i = 0; i < RoomCount; i++)
            {
                if (ListOfRooms[i].RoomNumber == room.RoomNumber)
                {
                    // Shift everything left by one
                    for (int j = i; j < RoomCount - 1; j++)
                    {
                        ListOfRooms[j] = ListOfRooms[j + 1];
                    }

                    // clear the last slot
                    ListOfRooms[RoomCount - 1] = null;

                    // Update the counter
                    RoomCount--;

                    break; // Stop after removal
                }
            }
        }

        // Method to search a room
        public bool SearchRoom(int roomNumber)
        {
            for (int i = 0; i < RoomCount; i++)
            {
                if (ListOfRooms[i].RoomNumber == roomNumber)
                {
                    return true;
                }
            }

            return false;
        }

        // Method to display available rooms
        public void DisplayAvailableRooms()
        {
            for (int i = 0; i < RoomCount; i++)
            {
                ListOfRooms[i].DisplayRoomInfo();
            }

        }
    }
}