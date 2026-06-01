using Hotel_Reservation_System;

try
{
    // Creating Guest objects
    var guest1 = new Guest("Sani", "Bello", "07045435653");
    var guest2 = new Guest("Usman", "Musa", "08137097856");
    var guest3 = new Guest("Umar", "Ahmad", "07030778463");

    // Create a room number for a new hotel Rooms
    HotelRoomNumber roomNumber1 = new HotelRoomNumber(01);
    HotelRoomNumber roomNumber2 = new HotelRoomNumber(02);
    HotelRoomNumber roomNumber3 = new HotelRoomNumber(03);
    HotelRoomNumber roomNumber4 = new HotelRoomNumber(04);
    HotelRoomNumber roomNumber5 = new HotelRoomNumber(05);

    // Creating Room objects
    var room1 = new Room(roomNumber1, RoomType.Standard, 10000);
    var room2 = new Room(roomNumber2, RoomType.Deluxe, 15000);
    var room3 = new Room(roomNumber3, RoomType.Suite, 20000);
    var room4 = new Room(roomNumber4, RoomType.Standard, 10000);
    var room5 = new Room(roomNumber5, RoomType.Deluxe, 15000);

    // Creating Reserve object
    var reserve1 = new Reservation(guest1, room1, 5);
    var reserve2 = new Reservation(guest2, room2, 2);

    // Creating Hotel object
    var hotel = new Hotel(hotelName: "Unity Hotel");

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
    room1.DisplayRoomInfo();

    hotel.DisplayAvailableRooms();

    hotel.SearchRoom(roomNumber5);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}