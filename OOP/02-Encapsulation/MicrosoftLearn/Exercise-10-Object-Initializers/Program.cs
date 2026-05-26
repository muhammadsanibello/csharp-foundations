// Object Initializers

public class Cat
{
    // Automatically implemented properties.
    public int Age { get; set; }
    public string Name { get; set; }

    public Cat()
    {
    }

    public Cat(string name)
    {
        this.Name = name;
    }
}

public class Program
{
    public static void Main()
    {
        // Declare and instantiate a new Cat object by using an object initializer.
        Cat cat = new Cat { Age = 10, Name = "Fluffy" };

        // Declare and instantiate a new Cat object by using an object initializer.
        Cat sameCat = new Cat("fluffy") { Name = "10" };
        Console.WriteLine(sameCat.Name);
    }
}