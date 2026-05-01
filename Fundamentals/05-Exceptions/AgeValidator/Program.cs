// Age Validator App

// Prompt user for his age
Console.Write("Enter your age: ");
string? response = Console.ReadLine();

if (!(int.TryParse(response, out int age)))
{
    Console.WriteLine("Error! Age must be a number.");
    return;
}

try
{
    ValidRange(age);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.Write($"Error! {ex.Message}");
}

// Range validity checking
void ValidRange(int age)
{
    if (age < 1 || age > 120)
    {
        throw new ArgumentOutOfRangeException("age", "Age must be between 1 and 120.");
    }

    Console.WriteLine("You are Welcome!");
}