// Defining the base clas 'Vehicle'
public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

// Defining child class 'Car'
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void OpenTrunk()
    {
        Console.WriteLine("Trunk opened.");
    }

    public void HonkHorn()
    {
        Console.WriteLine("Horn honked.");
    }

    public void LockDoors()
    {
        Console.WriteLine("Doors locked");
    }
}

// Creating transitive nature of inheritance
public class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }

    public void ChargeBattery()
    {
        Console.WriteLine("Battery charging.");
    }

    public void DisplayBatteryStatus()
    {
        Console.WriteLine("Battery status displayed.");
    }
}

// Creating transitive nature of inheritance
public class CombustionEngineCar : Car
{
    public int FuelCapacity { get; set; }

    public void Refuel()
    {
        Console.WriteLine("Car refueled.");
    }

    public void CheckOilLevel()
    {
        Console.WriteLine("Oil level checked.");
    }
}

// Testing
class Program
{
    static void Main()
    {
        Vehicle electricCar = new ElectricCar() { Make = "Tesla", Model = "S20G", NumberOfDoors = 4, BatteryCapacity = 10000};
        Vehicle combustionEngineCar = new CombustionEngineCar() { Make = "Toyota", Model = "Corolla LE", NumberOfDoors = 4, FuelCapacity = 50};

        electricCar.StartEngine();
        electricCar.StopEngine();

        // Casting
        //((ElectricCar)electricCar).OpenTrunk();

        // Another casting example
        ElectricCar electric = (ElectricCar)electricCar;
        electric.OpenTrunk();
        electric.HonkHorn();
        electric.LockDoors();
        electric.ChargeBattery();
        electric.DisplayBatteryStatus();

    }
}