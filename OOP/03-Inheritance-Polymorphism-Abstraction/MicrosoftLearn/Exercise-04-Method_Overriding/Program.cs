// Define the parent class 'Vehicle'
public class Vehicle
{
    public virtual string Start()
    {
        return "Vehicle is starting...";
    }
}

// Define the child class 'Car', inheriting from 'Vehicle'
public class Car : Vehicle
{
    // Override the parent class method
    public override string Start()
    {
        return base.Start() + "Beep! Beep!";
    }
}

public class Program
{
    static void Main()
    {
        var car = new Car();
        Console.WriteLine(car.Start());
    }
}