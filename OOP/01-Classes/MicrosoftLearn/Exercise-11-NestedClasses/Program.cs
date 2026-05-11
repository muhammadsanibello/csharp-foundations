// Nested Classes

// example 1
public class Container
{
    class Nested
    {
        Nested() { }
    }
}

// Making the Nested class public

public class Laptop
{
    public class Nested
    {
        Nested() { }
    }
}

public class Phone
{
    public class Nested
    {
        private Phone? parent;

        public Nested()
        {

        }
        public Nested(Phone parent)
        {
            this.parent = parent;
        }
    }
}

class Program
{
    static void Main()
    {
        Phone.Nested nest = new Phone.Nested();
    }
}