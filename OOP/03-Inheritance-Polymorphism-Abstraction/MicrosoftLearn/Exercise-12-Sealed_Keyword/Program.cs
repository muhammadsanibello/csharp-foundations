public class BaseClass
{
    public virtual void Method1()
    {
        Console.WriteLine("Method1 in BaseClass");
    }

    public virtual void Method2()
    {
        Console.WriteLine("Method2 in BaseClass");
    }
}

public class DerivedClass : BaseClass
{
    public sealed override void Method1()
    {
        Console.WriteLine("Method1 in DerivedClass");
    }

    public override void Method2()
    {
        Console.WriteLine("Method2 in DerivedClass");
    }
}

public class FinalClass : DerivedClass
{
    // This class can't override Method1 because it's sealed in DerivedClass
    public override void Method2()
    {
        Console.WriteLine("Method2 in FinalClass");
    }
}

class Program
{
    static void Main()
    {
        BaseClass final = new FinalClass();
        final.Method2();
    }
}