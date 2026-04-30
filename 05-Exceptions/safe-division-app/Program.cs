// Safe Division App
bool playAgain = true;

while (playAgain)
{
    Console.Write("Enter first number: ");
    string? firstNumber = Console.ReadLine();

    Console.Write("Enter second number: ");
    string? secondNumber = Console.ReadLine();

    if (!(decimal.TryParse(firstNumber, out decimal number1) && decimal.TryParse(secondNumber, out decimal number2)))
    {
        Console.WriteLine("Invalid input\n");
        continue;
    }

    if (number2 == 0)
    {
        Console.WriteLine("Cannot divide by zero.\n");
    }
    else
    {
        Console.WriteLine($"Result: {number1 / number2}\n");
    }

    playAgain =  ContinueOption();
}

bool ContinueOption()
{
    Console.WriteLine("Do you like to continue? (y/n)");
    string? option = Console.ReadLine();

    if (option.ToLower().Trim() == "y")
    {
        return true;
    }
    else if (option.ToLower().Trim() == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Invalid option! Try again.\n");
        return true;
    }
}