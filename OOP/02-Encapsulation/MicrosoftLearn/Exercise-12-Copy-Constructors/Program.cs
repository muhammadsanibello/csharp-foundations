// Copy Constructors

public sealed class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    // Instance constructor.
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy constructor
    public Person(Person previousPerson)
    {
        Name = previousPerson.Name;
        Age = previousPerson.Age;
    }

    // Method
    public string Details()
    {
        return Name + " is " + Age;
    }
}

class Program
{
    static void Main()
    {
        var person1 = new Person(age: 20, name: "Sani");

        //copying person1.
        var person2 = new Person(person1);
        Console.WriteLine(person1.Details());
        Console.WriteLine(person2.Details());
    }
}