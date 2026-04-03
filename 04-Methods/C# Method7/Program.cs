// Test by value

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} * {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} * {b} = {c}");
}

// Test by reference

int[] array = [1, 2, 3, 4, 5];

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;   
    }
}

// Test with string
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}