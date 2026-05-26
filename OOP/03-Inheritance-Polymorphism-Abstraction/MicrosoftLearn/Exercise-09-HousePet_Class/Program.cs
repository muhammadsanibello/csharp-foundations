// Defining the base class 'HousePet'
public class HousePet
{
    public virtual string Speak()
    {
        return "Hello";
    }
}

// Defining one of child class 'Dog'
public class Dog : HousePet
{
    // Override the inherited method
    public override string Speak()
    {
        return "Woof";
    }
}

// Defining another child class 'Cat'
public class Cat : HousePet
{
    // Override the inherited method
    public override string Speak()
    {
        return "Meow";
    }
}

// Testing
class Program
{
    static void Main()
    {
        // Create a HousePet object named 'myPet1' that's of type Dog
        HousePet myPet1 = new Dog();

        // Create a HousePet object named 'myPet2' that's of type Cat
        HousePet myPet2 = new Cat();

        Console.WriteLine(myPet1.Speak());
        Console.WriteLine(myPet2.Speak());
    }
}