string? input;
bool validEntry = false;
Console.WriteLine("Enter your role (Administrator, Manager, or User)");

do
{
    input = Console.ReadLine() ?? "";
    if ((input.Trim().ToLower() == "administrator") || (input.Trim().ToLower() == "manager") || (input.Trim().ToLower() == "user"))
        validEntry = true;

    else
        Console.WriteLine($"The code that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
} while (validEntry == false);

Console.WriteLine($"Your input value ({input}) has been accepted.");