// Covariance in generics

public interface ICovariant<out T> { T Get(); }

// Contravariance in generics
public interface IContravariant<in T> { void Set(T value); }

public class Animal { }
public class Dog : Animal { }

public class CovarianceExample : ICovariant<Dog>
{
    public Dog Get() => new Dog();
}

public class ContravariantExample : IContravariant<Animal>
{
    public void Set(Animal value) { }
}

public class Program
{
    public static void Main()
    {
        ICovariant<Animal> covariant = new CovarianceExample();
        Animal animal = covariant.Get();

        IContravariant<Dog> contravariant = new ContravariantExample();
        contravariant.Set(new Dog());
    }
}