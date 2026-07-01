// Covariance with Func

public class Person { }
public class Employee : Person { }

public class Animal { }
public class Dog : Animal { }

public class Program
{
    public static Employee FindEmployee(string title) => new Employee();

    public static void HandleAnimal(Animal animal) { }

    public static void Main()
    {
        Func<string, Person> func = FindEmployee;
        Person person = func("Manager");

        Action<Dog> action = HandleAnimal;
        action(new Dog());
    }
}