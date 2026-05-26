// Required properties syntax

using System.Diagnostics.CodeAnalysis;

public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }

    // Omitted for brevity. 
}

class Program
{
    static void Main()
    {
        var aPerson = new Person("Sani");
        aPerson = new Person { FirstName = "Sani" };
        Console.WriteLine(aPerson.FirstName);
    }
}