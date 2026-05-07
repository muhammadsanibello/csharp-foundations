// Read/Write properties basics

class Person
{
    private string _name = "N/A";
    private int _age = 0;

    // Declare a Name property of type string:
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Declare an Age property of type int:
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }
}

class TestPerson
{
    static void Main()
    {
        // create a new Person object named person:
        var person = new Person();

        // Print out the default name and age of the person:
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Set some values on the person object:
        person.Name = "PersonName";
        person.Age = 99;
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Increment the Age property:
        person.Age += 1;
        Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}