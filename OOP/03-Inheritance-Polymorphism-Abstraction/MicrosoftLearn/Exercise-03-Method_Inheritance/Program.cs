// Define the parent class
public class Vehicle
{
    public string Brand { get; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    // Method to start a vehicle
    public void Start()
    {
        Console.WriteLine($"The {Brand} is starting.");
    }
}

// Define the child class 'Car', inheriting from 'Vehicle'
public class Car : Vehicle
{
    public Car(string brand) : base(brand) { }

}

public class Program
{
    static void Main()
    {
        var myCar = new Car("Honda");
        Console.WriteLine(myCar.Brand);
        myCar.Start();
    }
}