Console.WriteLine("Enter the name of your favourite fruits: ");
string fruit = Console.ReadLine() ?? "";
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for appple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}