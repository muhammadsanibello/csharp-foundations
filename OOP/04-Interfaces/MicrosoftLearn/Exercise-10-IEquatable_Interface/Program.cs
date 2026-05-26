// IEquatable interface
public class Car : IEquatable<Car>
{
    public string? Make { get; set; }
    public string? Model { get; set; }

    public bool Equals(Car? other)
    {
        if (other == null) return false;

        return this.Make == other.Make && this.Model == other.Model;
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car { Make = "Toyota", Model = "Camry" };
        Car car2 = new Car { Make = "Peogeut", Model = "406" };

        Console.WriteLine(car1.Equals(car2));
    }
}