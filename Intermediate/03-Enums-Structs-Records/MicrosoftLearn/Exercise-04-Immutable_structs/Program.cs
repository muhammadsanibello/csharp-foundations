// Apply readonly modifier to a struct
public readonly struct ImmutablePoint
{
    public int X { get; init; }
    public int Y { get; init; }

    public ImmutablePoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        var point = new ImmutablePoint { X = 20, Y = 30};
        Console.WriteLine(point.X);
        Console.WriteLine(point.Y);
    }
}