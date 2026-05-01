// Simple Calculator program

Add(0.87, 5);
Subtract(26, 13);
Multiply(4, 4);
Divide(40, 0.5);
Max(56, 87);
Min(34, 56);
Sqr(64);

void Add(double x, double y)
{
    double z = x + y;
    Console.WriteLine($"The Sum of {x} + {y} = {z}");
    Console.WriteLine();
}

void Subtract(double x, double y)
{
    double z = x - y;
    Console.WriteLine($"The Result of {x} - {y} = {z}");
    Console.WriteLine();
}

void Multiply(double x, double y)
{
    double z = x * y;
    Console.WriteLine($"The Product of {x} * {y} = {z}");
    Console.WriteLine();
}

void Divide(double x, double y)
{
    double z = x / y;
    Console.WriteLine($"The Result of {x} / {y} = {z}");
    Console.WriteLine();
}

void Sqr(double x)
{
    double z = Math.Sqrt(x);
    Console.WriteLine($"The Square of {x} is {z}");
    Console.WriteLine();
}

void Min(double x, double y)
{
    double z = Math.Min(x, y);
    Console.WriteLine($"The minimum value between {x} and {y} is {z}");
    Console.WriteLine();
}

void Max(double x, double y)
{
    double z = Math.Max(x, y);
    Console.WriteLine($"The maximum value between {x} and {y} is {z}");
    Console.WriteLine();
}