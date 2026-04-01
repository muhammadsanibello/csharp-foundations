string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");

do
{
    readResult = Console.ReadLine();
    if (readResult.Length >= 3)

        validEntry = true;

    else
        Console.WriteLine("Invalid input. please try again.");
} while (validEntry == false);