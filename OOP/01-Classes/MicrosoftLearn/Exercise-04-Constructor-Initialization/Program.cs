// Initialize class data using constructor parameters

public class Person
{
    public string personName;
    public string personAge;

    public Person()
    {
        // Field initialization and constructor logic goes here.
        personName = "unknown";
        personAge = "unknown";
    }

    public Person(string name)
    {
        // Field initialization and constructor logic goes here.
        personName = name;
        personAge = "unknown";
    }

    public Person(string name, int age)
    {
        // Field initialization and constructor logic goes here.
        personName = name;
        personAge = age.ToString();
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

        Console.WriteLine($"Person 1 Name: {person1.personName} Age: {person1.personAge}");
        Console.WriteLine($"Person 2 Name: {person2.personName} Age: {person2.personAge}");
        Console.WriteLine($"Person 3 Name: {person3.personName} Age: {person3.personAge}");
    }
}