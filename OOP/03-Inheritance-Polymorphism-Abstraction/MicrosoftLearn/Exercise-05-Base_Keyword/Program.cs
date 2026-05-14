// Define the parent class 'ParentClass'
public class ParentClass
{
    // Initialize the 'ParentClass' with Value attribute
    public string Value { get; }

    public ParentClass(string value)
    {
        Value = value;
    }
}

// Define the child class 'ChildClass', inheriting from 'ParentClass'
public class ChildClass : ParentClass
{
    // Initialize the 'ChildClass' with Additional Value attribute
    public string AdditionalValue { get; }
    
    public ChildClass(string value, string additionalValue) : base(value)
    {
        AdditionalValue = additionalValue;
    }
}

public class Program 
{
    static void Main()
    {
        var childClass = new ChildClass("value", "additional_value");
        Console.WriteLine(childClass.Value);
        Console.WriteLine(childClass.AdditionalValue);
    }
}