// Safe Division App
Console.Write("Enter first number: ");
string? firstNumber = Console.ReadLine();

Console.Write("Enter second number: ");
string? secondNumber = Console.ReadLine();

if (decimal.TryParse(firstNumber, out decimal number1) && decimal.TryParse(secondNumber, out decimal number2))
{
    try
    {
        Console.WriteLine($"Result: {number1 / number2}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Cannot divide by zero. " + ex.Message);
    }
}
else
{
    Console.WriteLine("Invalid input.");
}

Console.WriteLine("Exiting...");