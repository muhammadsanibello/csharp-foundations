// Car Rental System

using CarRentalSystem;

var car1 = new Car();
var car2 = new Car("Toyota", "Civic", 2025);
var car3 = new Car("Peogeut", "406", 2020);

car1.DisplayCarInfo();
car1.RentCar();
car1.ReturnCar();

Console.WriteLine();

car2.DisplayCarInfo();
car2.RentCar();
car2.ReturnCar();

Console.WriteLine();

car3.DisplayCarInfo();
car3.RentCar();
car3.ReturnCar();