HashSet<string> names = new HashSet<string>();

// Adding items
names.Add("Sani");
names.Add("Bello");

foreach (string name in names)
{
    Console.WriteLine(name);
}

// Verifying items
if (names.Contains("Sani"))
{
    Console.WriteLine("Sani is in the collection.");
}

// Preventing duplicates
names.Add("Usman");
names.Add("Usman"); // Duplicate, won't be added

foreach (string name in names)
{
    Console.WriteLine(name);
}