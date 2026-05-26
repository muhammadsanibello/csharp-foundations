// Base class
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class Dog
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Derived class Cat
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

// Derived class Cow
public class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cow moos.");
    }
}

class Program
{
    static void Main()
    {
        // Create an array of Animal objects
        Animal[] animals = new Animal[3];

        Animal animal1 = new Dog();
        Animal animal2 = new Cat();
        Animal animal3 = new Cow();

        animals[0] = animal1;
        animals[1] = animal2;
        animals[2] = animal3;

        // Demonstrate polymorphism
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}