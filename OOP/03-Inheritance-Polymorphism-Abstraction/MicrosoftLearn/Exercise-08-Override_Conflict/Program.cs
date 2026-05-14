public class A
{
    public void Method1()
    {
        // Do something.
    }
}

public class B : A
{
    public override void Method1() // Error: Generate CS0506
    {
        // Do something else
    }
}

// Abstract members
public abstract class A1
{
    public abstract void Method1();
}

public class B1 : A1  // Generate CS0534
{
    public void Method3()
    {
        // Do something
    }
}