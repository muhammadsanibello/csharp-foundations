// Creating an abstract class 'Shape'
public abstract class Shape
{
    public abstract int GetArea();
}

// Creating a child class 'Square'
public class Square : Shape
{
    private int _side;

    public Square(int side)
    {
        _side = side;
    }

    public override int GetArea()
    {
        return _side * _side;
    }
}

// testing
class Program
{
    static void Main()
    {
        Shape square = new Square(5);
        Console.WriteLine($"Area of the square = {square.GetArea()}");
    }
}