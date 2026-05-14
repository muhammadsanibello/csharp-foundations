// Define the parent class 'Vehicle'
class Vehicle
{
    // Initialize the Vehicle with color and brand attributes
    public string Color { get; }
    public string Brand { get; }

    public Vehicle(string color, string brand)
    {
        Color = color;
        Brand = brand;
    }
}

// Define the child class 'Car', inheriting from 'Vehicle'
class Car : Vehicle
{
    public int Doors { get; }

    public Car(string color, string brand, int doors) : base(color, brand)
    {
        Doors = doors;
    }
}

class Program
{
    static void Main()
    {
        var car = new Car("Red", "Toyota", 2);

        Console.WriteLine(car.Color);
        Console.WriteLine(car.Brand);
        Console.WriteLine(car.Doors);
    }
}