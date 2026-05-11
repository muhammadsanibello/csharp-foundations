// Object initializers with the required modifier

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public required string LastName { get; set; }
}

public class Program
{
    static void Main()
    {
        var person = new Person() { FirstName = "Sani", LastName = "Bello"};
        person.LastName = "h";
        person.FirstName = "H";
        Console.WriteLine(person.LastName);
    }
}