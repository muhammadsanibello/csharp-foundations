using System;

namespace CarRentalSystem
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        bool IsAvailable;

        public Car()
        {

        }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            IsAvailable = true;
            Year = year;
        }

        public void RentCar()
        {
            if (!IsAvailable)
            {
                Console.WriteLine("\nCar is not available.");
                return;
            }

            IsAvailable = false;
            Console.WriteLine("\nCar rented successfully.");
        }

        public void ReturnCar()
        {
            IsAvailable = true;
            Console.WriteLine("\nCar returned successfully.");
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($" Car Brand: {Brand}\n Car Model: {Model}\n Car Year: {Year}\n Availability: {IsAvailable}");
        }
    }
}
