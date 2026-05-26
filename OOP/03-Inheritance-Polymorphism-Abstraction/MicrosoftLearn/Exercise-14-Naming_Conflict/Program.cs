public class BaseClass
{
    public string Property1 { get; set; } = "Base - Property1";
    public string Property2 { get; set; } = "Base - Property2";

    public void Method1()
    {
        Console.WriteLine("Base - Method1");
    }

    public void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
}

public class DerivedClass : BaseClass
{
    public new string Property2 { get; set; } = "Derived - Property2";

    public new void Method2()
    {
        Console.WriteLine("Derived - Method2");
    }
}

class Program
{
    static void Main()
    {
        // create instance of the base class and the derived classes
        BaseClass baseClass = new BaseClass();
        DerivedClass derivedClass = new DerivedClass();
        BaseClass baseClassReferencingDerivedClass = new DerivedClass();

        // access properties and methods of the base class
        Console.WriteLine($"\n{baseClass.Property1}");
        Console.WriteLine($"{baseClass.Property2}");
        baseClass.Method1();
        baseClass.Method2();

        // access properties and methods of the derived class
        Console.WriteLine($"\n{derivedClass.Property1}");
        Console.WriteLine($"{derivedClass.Property2}");
        derivedClass.Method1();
        derivedClass.Method2();

        // access properties and methods of the base class that references the derived class
        Console.WriteLine($"\n{baseClassReferencingDerivedClass.Property1}");
        Console.WriteLine($"{baseClassReferencingDerivedClass.Property2}");
        baseClassReferencingDerivedClass.Method1();
        baseClassReferencingDerivedClass.Method2();
    }
}