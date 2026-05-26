// Defining the 'IVehicle' interface
public interface IVehicle
{
    // Interface properties
    int Speed { get; set; }
    string Color { get; set; }
}

// Implementing the interface
public class Car : IVehicle
{
    private int _speed;
    private string _color;

    public int Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public string Color
    {
        get => _color;
        set => _color = value;
    }
}

public class Program
{
    static void Main()
    {
        IVehicle car = new Car();
        car.Speed = 100;
        car.Color = "White";
        Console.WriteLine(car.Speed);
        Console.WriteLine(car.Color);
    }
}