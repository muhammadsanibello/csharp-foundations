// EvenOddChecker

Console.WriteLine("Enter a Number:\n");
string? input = Console.ReadLine();
int number = 0;

if (int.TryParse(input, out number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} is even");
    }
    else
    {
        Console.WriteLine($"{number} is odd");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}