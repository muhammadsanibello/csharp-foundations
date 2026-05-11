// Hotel Reservation Management System

using Hotel_Reservation_System;

try
{
    // Creating Guest objects
    var guest1 = new Guest("Sani", "Bello", "07045435653");
    var guest2 = new Guest("Usman", "Musa", "08137097856");
    var guest3 = new Guest("Umar", "Ahmad", "07030778463");


    // Creating Room objects
    var room1 = new Room(01, "Standard", 10000);
    var room2 = new Room(02, "Deluxe", 15000);
    var room3 = new Room(03, "Suite", 20000);
    var room4 = new Room(04, "Standard", 10000);
    var room5 = new Room(05, "Deluxe", 15000);

    // Creating Reserve object
    var reserve1 = new Reservation(guest1, room1, 5);
    var reserve2 = new Reservation(guest2, room2, 2);

    // Creating Hotel object
    var hotel = new Hotel(hotelName: "Unity Hotel", maximumRooms: 4);

    // Adding room to hotel
    hotel.AddRoom(room1);
    hotel.AddRoom(room2);
    hotel.AddRoom(room3);
    hotel.AddRoom(room4);
    hotel.AddRoom(room5);

    // Display hotel available rooms
    hotel.DisplayAvailableRooms();

    // Reserve a room
    hotel.ReserveRoom(reserve1);
    hotel.ReserveRoom(reserve1);
    hotel.CancelReservation(reserve1);
    hotel.ReserveRoom(reserve1);

    hotel.DisplayAvailableRooms();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}