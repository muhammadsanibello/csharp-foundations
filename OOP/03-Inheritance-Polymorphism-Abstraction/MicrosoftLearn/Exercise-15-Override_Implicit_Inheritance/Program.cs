// Defining the abstract base class 'BaseClass'
public abstract class BaseClass
{
    public abstract string Property1 { get; set; }
    public virtual string Property2 { get; set; } = "Base - Property2";

    public abstract void Method1();

    public void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
}

// Defining a child class 'DerivedClass1'
public class DerivedClass1 : BaseClass
{
    public override string Property1 { get; set; } = "Derived1 - Property1";
    public new string Property2 { get; set; } = "Derived1 - Property2";

    public override void Method1()
    {
        Console.WriteLine("Derived1 - Method1");
    }

    public new void Method2()
    {
        Console.WriteLine("Derived1 - Method2");
    }
}

// Defining another child class 'DerivedClass2'
public class DerivedClass2 : BaseClass
{
    public override string Property1 { get; set; } = "Derived2 - Property1";
    public new string Property2 { get; set; } = "Derived2 - Property2";

    public override void Method1()
    {
        Console.WriteLine("Derived2 - Method1");
    }

    public new void Method2()
    {
        Console.WriteLine("Derived2 - Method2");
    }

    // Override ToString method
    public override string ToString()
    {
        return $"DerivedClass2: Property1 = {Property1}, Property2 = {Property2}";
    }

    // Override Equals Method
    public override bool Equals(object? obj)
    {
        if (obj is DerivedClass2 other)
        {
            return Property1 == other.Property1 && Property2 == other.Property2;
        }
        return false;

    }

    // Override GetHashCode method
    public override int GetHashCode()
    {
        return HashCode.Combine(Property1, Property2);
    }
}

// Testing
class Program
{
    static void Main()
    {
        // create instances of the derived classes
        DerivedClass1 derivedClass1 = new DerivedClass1();
        DerivedClass2 derivedClass2a = new DerivedClass2 { Property1 = "Value1", Property2 = "Value2" };
        DerivedClass2 derivedClass2b = new DerivedClass2 { Property1 = "Value1", Property2 = "Value2" };
        DerivedClass2 derivedClass2c = new DerivedClass2 { Property1 = "Value3", Property2 = "Value4" };

        // demonstrate object class methods for DerivedClass1
        Console.WriteLine("\nDemonstrating Object class methods for DerivedClass1:");
        Console.WriteLine($"ToString: {derivedClass1.ToString()}");
        Console.WriteLine($"Equals: {derivedClass1.Equals(new DerivedClass1())}");
        Console.WriteLine($"GetHashCode: {derivedClass1.GetHashCode()}");

        // demonstrate overridden Object class methods for DerivedClass2
        Console.WriteLine("\nDemonstrating overridden Object class methods for DerivedClass2:");
        Console.WriteLine($"ToString: {derivedClass2a.ToString()}");
        Console.WriteLine($"Equals (derivedClass2a vs derivedClass2b): {derivedClass2a.Equals(derivedClass2b)}"); // should return true
        Console.WriteLine($"Equals (derivedClass2a vs derivedClass2c): {derivedClass2a.Equals(derivedClass2c)}"); // should return false
        Console.WriteLine($"GetHashCode (derivedClass2a): {derivedClass2a.GetHashCode()}");
        Console.WriteLine($"GetHashCode (derivedClass2b): {derivedClass2b.GetHashCode()}");
        Console.WriteLine($"GetHashCode (derivedClass2c): {derivedClass2c.GetHashCode()}");
    }
}