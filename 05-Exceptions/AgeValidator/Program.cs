// Age Validator App

// Prompt user for his age
Console.Write("Enter your age: ");
string? response = Console.ReadLine();

if (int.TryParse(response, out int age))
{
    try
    {
        ValidRange();
    }
    catch (Exception ex)
    {
        Console.Write("Error! " + ex.Message);
    }
}
else
{
    Console.WriteLine("Error! Age must be a number.");
}

// Range validity checking
void ValidRange()
{
    if (age >= 1 && age <= 120)
    {
        Console.WriteLine("You are Welcome!");
    }
    else
    {
        throw new Exception("\"InvalidRange\": Age is out of range.");
    }
    Console.WriteLine();
}