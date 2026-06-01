// Define a record for immutable data models
public record Person(string FirstName, string LastName);

class Program
{
    static void Main()
    {
        var person1 = new Person("Sani", "Bello");
        var person2 = new Person("Sani", "Bello");
        Console.WriteLine(person2);
        Console.WriteLine(person1 == person2);
    }
}