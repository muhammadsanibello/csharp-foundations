// Defining the 'IVehicle' interface
public interface IVehicle
{
    int Speed { get; set; }
    string Color { get; set; }

    void Drive();
}

// Implementing the interfce
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

    public void Drive()
    {
        // Implementation of the Drive method
        Console.WriteLine("The car is driving.");
    }
}

class Program
{
    static void Main()
    {
        IVehicle car = new Car();
        car.Drive();
        car.Speed = 100;
    }
}