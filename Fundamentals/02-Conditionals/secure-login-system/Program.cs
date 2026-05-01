// Secure Login System
string pin = "12345";
int maxAttempts = 3;
int attempt = 0;

while (attempt < maxAttempts)
{
    maxAttempts--;
    Console.Write("Enter Pin: ");
    string? pinResponse = Console.ReadLine();

    if (pinResponse == pin)
    {
        Console.WriteLine("\nAccess granted!");
        break;
    }
    else
    {
        Console.WriteLine("\nInvalid pin!");
    }
    Console.WriteLine();
}