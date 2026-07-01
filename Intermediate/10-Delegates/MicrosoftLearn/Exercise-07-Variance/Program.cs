// Variance with custom delegates

public class Animal { }
public class Dog : Animal { }

// Define a delegate that takes a Dog and retun an Animal
public delegate Animal AnimalDelegate(Dog dog);

public class Program
{

    // Method that matches the delegate signature
    public static Animal GetAnimal(Dog dog) => new Animal();

    // Method that uses covariance (returns a more derived type)
    public static Dog GetDog(Dog dog) => new Dog();

    // Method that uses contravariance (accept a less derived type)
    public static Animal GetAnimalFromAnimal(Animal animal) => new Animal();
    public static void Main()
    {
        AnimalDelegate del;

        // Assign method with matching signature
        del = GetAnimal;
        Console.WriteLine(del(new Dog()).GetType());

        // Assign method with covariant return type
        del = GetDog;
        Console.WriteLine(del(new Dog()).GetType());

        // Assign method with contravariant parameter type
        del = GetAnimalFromAnimal;
        Console.WriteLine(del(new Dog()).GetType());
    }
}