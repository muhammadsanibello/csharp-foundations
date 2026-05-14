// Define the parent class 'A'

public class A
{
    public void Method1()
    {
        // Method implementation.
    }
}

// Define the derive class 'B', inheriting from 'A'
public class B : A { }

public class  Example
{
    public static void Main()
    {
        var b = new B();
        b.Method1();
    }
}