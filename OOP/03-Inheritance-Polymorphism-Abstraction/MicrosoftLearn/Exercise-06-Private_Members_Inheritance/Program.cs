// Define the parent class 'A'

public class A
{
    private int _value = 10;

    // Define the derive nested class 'B', inheriting from 'A'
    public class B : A
    {
        public int GetValue()
        {
            return _value;
        }
    }
}

// Define the derive class 'C', inheriting from 'A'
public class C : A
{
    //public int GetValue()
    //{
    //    return _value;
    //}
}

public class AccessExample
{
    public static void Main(string[] args)
    {
        var b = new A.B();
        Console.WriteLine(b.GetValue());
    }
}