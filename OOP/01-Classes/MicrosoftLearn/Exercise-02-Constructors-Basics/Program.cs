// A Class Constructor

// Class with single constructor
public class Person
{

    public Person()
    {
        // Field initialization and constructor logic goes here.
    }

    // Remaining implementation of Person class
}

// Class with two contructors
public class Person1
{

    public Person1()
    {

        // Field initialization and constructor goes here
        string name = "John Doe";
        Console.WriteLine($"Person created: {name}");

    }

    public Person1(string fName, string lName)
    {
        string name = fName + " " + lName;

        Console.WriteLine($"Person created: {name}");
    }

    // Remaining implementaion of Person1 class
}

// Instantiate objects using class contructors
public class Person2
{
    public Person2()
    {
        // Field initialization and constructor logic goes here.
    }
}

static class Program
{
    // the Main method is the entry point of the program
    static void Main()
    {
        Person2 person3 = new Person2();
    }
}