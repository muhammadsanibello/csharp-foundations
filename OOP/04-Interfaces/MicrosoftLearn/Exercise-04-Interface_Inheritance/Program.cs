interface IDrawable
{
    void Draw();
}

interface IShape : IDrawable
{
    double Area { get; }
}

public class Circle(double radius) : IShape
{
    public double Area => Math.PI * radius * radius;

    public void Draw() => Console.WriteLine($"Drawing circle with area {Area:F2}");
}