// A Class Constructor Part 2

// A Class with three constructors
public class Person
{

    public Person()
    {
        // Field initialization and constructor logic goes here.

        Console.WriteLine("An instance of the Person class is being instantiated without name or age parameter.");
    }

    public Person(string name)
    {
        // Field initialization and constructor logic goes here.

        Console.WriteLine($"An instance of the Person class is being instantiated using a name ({name}) parameter.");
    }

    public Person(string name, int age)
    {
        // Field initialization and constructor logic goes here.

        Console.WriteLine($"An instance of the Person class is being instantiated using name ({name}) and ({age}) parameters.");
    }
}

static class Program
{
    // the Main method is the entry point of the program.
    static void Main()
    {
        Person person1 = new Person();
        Person person2 = new Person("Jane Doe");
        Person person3 = new Person("Jane Doe", 30);
    }
}

// Classes with no constructors
public class Person1
{
    public int age;
    public string name = "unknown";
}

class Example
{
    static void Main()
    {
        var person = new Person1();
        Console.WriteLine($"Name: {person.name}, Age: {person.age}");
        // Output: Name: unknown, Age: 0
    }
}