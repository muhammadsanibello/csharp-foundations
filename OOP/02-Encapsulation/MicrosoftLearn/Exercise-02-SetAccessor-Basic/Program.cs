// get and set accessors basics

class Student
{
    private string? _name;  // the name field
    public string Name      // the Name property
    {
        get
        {
            return _name != null ? _name : "NA";
        }
        set
        {
            _name = value;
        }
    }
}

class Program
{
    static void Main()
    {
        var student1 = new Student();
        Console.WriteLine(student1.Name);  // the get accessor is invoked here
        
        student1.Name = "Sani";            // the set accessor is invoked here
        Console.WriteLine(student1.Name);
    }
}