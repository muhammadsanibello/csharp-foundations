// Writing my first C# method

void SayHello()     // a method signature
{
    Console.WriteLine("Hello World!");
}
SayHello();

int[] a = [1, 2, 3, 4, 5];

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Before calling a method");
PrintHello();
Console.WriteLine("After calling a method");

void PrintHello()
{
    Console.WriteLine("Hello Muhammad!");
}