public struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point other)
    {
        int dx = X - other.X;
        int dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

class Program
{
    static void Main()
    {
        var point1 = new Point(3, 4);
        var point2 = new Point(7, 1);

        Console.WriteLine($"Distance between points: {point1.DistanceTo(point2)}"); ;
    }
}