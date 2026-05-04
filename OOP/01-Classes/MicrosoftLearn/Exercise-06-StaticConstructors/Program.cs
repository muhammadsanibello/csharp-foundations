// Static Fields and Constructors

public class Person
{
    public string personName;
    public string personAge;

    // static fields
    public static string defaultName;
    public static string defaultAge;

    // static constructor
    static Person()
    {
        // static field initialization
        defaultName = "unknown";
        defaultAge = "unknown";
    }

    public Person()
    {
        // field initialization and constructor logic goes here.
        personName = defaultName;
        personAge = defaultAge;
    }

    public Person(string name)
    {
        // field initialization and constructor logic goes here.
        personName = name;
        personAge = defaultAge;
    }
    
    public Person(string name, int age)
    {
        // field initialization and constructor logic goes here.
        personName = name;
        personAge = age.ToString();
    }
}

static class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person();
        var person2 = new Person("Sani Bello");
        var person3 = new Person("Sani Bello", 20);

        Console.WriteLine($"Person 1: Name: {person1.personName}, Age: {person1.personAge}");
        Console.WriteLine($"Person 2: Name: {person2.personName}, Age: {person2.personAge}");
        Console.WriteLine($"Person 3: Name: {person3.personName}, Age: {person3.personAge}");
    }
}