using System.Security.Cryptography.X509Certificates;

public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("The cat meow.");
    }
}

public class AnimalSound
{
    public void MakeAnimalSound(IAnimal animal)
    {
        animal.MakeSound();
    }
}

class Program
{
    static void Main()
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        AnimalSound animalSound = new AnimalSound();

        animalSound.MakeAnimalSound(dog);
        animalSound.MakeAnimalSound(cat);
    }
}