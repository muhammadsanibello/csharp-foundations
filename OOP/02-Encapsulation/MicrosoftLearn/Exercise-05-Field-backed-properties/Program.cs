// Field  backed properties

public class Person
{
    public string? FirstName
    {
        get => field;
        set => field = value.Trim();
    }
}

class Program
{
    static void Main()
    {
        var person = new Person();
        person.FirstName = "Sani";
        Console.WriteLine(person.FirstName);
    }
}