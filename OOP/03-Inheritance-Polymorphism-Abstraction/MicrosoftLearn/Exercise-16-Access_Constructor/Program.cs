// Defining an abstract base class 'Vehicle'
public abstract class Vehicle
{
    public virtual int Speed { get; set; }
    public virtual int Fuel { get; set; }

    public Vehicle(int speed, int fuel)
    {
        Speed = speed;
        Fuel = fuel;
    }

    public virtual void Drive()
    {
        Console.WriteLine("Vehicle is driving");
    }
}

// Creating child class 'Car' inheriting from Vehicle
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public int TrunkCapacity { get; set; }

    public Car(int speed, int fuel, int numberOfDoors) : base(speed, fuel)
    {
        NumberOfDoors = numberOfDoors;

        // Initialize TrunkCapacity based on the Speed and Fuel properties of the base class
        TrunkCapacity = CalculateTrunkCapacity(Speed, Fuel);
    }

    private int CalculateTrunkCapacity(int speed, int fuel)
    {
        // Example logic to calculate trunk capacity based on speed and fuel
        return (speed * fuel) / 2;
    }

    public override void Drive()
    {
        base.Drive();
        Console.WriteLine("Car is driving with additional features");
    }
}

// Testing
class Program
{
    static void Main()
    {
        Car car = new Car(100, 50, 4);
        Console.WriteLine($"Speed: {car.Speed}, Fuel: {car.Fuel}, Number of Doors: {car.NumberOfDoors}, TrunkCapacity: {car.TrunkCapacity}");
        car.Drive();
    }
}