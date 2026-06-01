using System;
using System.Runtime.CompilerServices;

namespace Hotel_Reservation_System
{

    // Create RoomType enum
    public enum RoomType
    {
        Standard,
        Deluxe,
        Suite
    }

    // Create an extension method to provide description of RoomType
    public static class RoomTypeExtensions
    {
        public static string GetDescription(this RoomType roomType)
        {
            return roomType switch
            {
                RoomType.Standard => "Cozy, clean, and affordable.",
                RoomType.Deluxe => "More space. Extra comfort.",
                RoomType.Suite => "Separate living. Total luxury.",
                _ => "Unknown room type"
            };
        }
    }

    // Create a room number struct
    public readonly struct HotelRoomNumber
    {
        public int Value { get; }

        public HotelRoomNumber(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Room number must be greater than zero");
            }

            Value = value;
        }

        public override string ToString() => Value.ToString();
    }

    public class Room
    {
        public HotelRoomNumber RoomNumber { get; }
        public RoomType RoomType { get; }
        public double PricePerNight { get; private set; }
        public bool IsBooked { get; private set; }

        // instance constructor
        public Room(HotelRoomNumber roomNumber, RoomType roomType, double pricePerNight)
        {
            if (pricePerNight < 0) throw new ArgumentException(nameof(pricePerNight), "Cannot be negative");

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
            Console.WriteLine("Room Information:\nRoom Number: {0}\nRoom Type: {1}\nDescription: {2}\nPrice Per Night: {3}\nBooking Status: {4}", RoomNumber, RoomType, RoomType.GetDescription(), PricePerNight, IsBooked ? "Booked" : "Available");
            Console.WriteLine();
        }
    }
}
