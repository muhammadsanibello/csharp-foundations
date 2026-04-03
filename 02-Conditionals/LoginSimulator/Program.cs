// LoginSimulator
string userName = "ByteGuardian19";
string password = "63341234";
int attempts = 0;
int maxAttempts = 3;

while (attempts < maxAttempts)
{
    Console.Write("Enter UserName:\t");
    string? userNameResponse = Console.ReadLine();

    Console.Write("Enter Password:\t");
    string? passwordResponse = Console.ReadLine();

    if (!string.IsNullOrEmpty(userNameResponse) && !string.IsNullOrEmpty(passwordResponse) && userNameResponse.Equals(userName, StringComparison.OrdinalIgnoreCase) && passwordResponse == password)
    {
        Console.WriteLine("\nLogin Successful");
        break;
    }

    else
    {
        attempts++;
        int remainingAttempts = maxAttempts - attempts;

        if (remainingAttempts > 0)
        {
            Console.WriteLine($"\nInvalid Credentials! {remainingAttempts} attempt(s) left...\n");
        }

        else
        {
            Console.WriteLine("\nToo many attempts! System locked");
        }
    }
}