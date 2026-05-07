// Expression-bodied members syntax

/*
 Expression-bodied members provide a more concise syntax
 for writing single-line property accessors.
*/

class Student
{
    private string? _name;      // the name field
    public string Name          // the Name property
    {
        get => _name ?? "NA";
        set => _name = value;
    }
}

class Program
{
    static void Main()
    {
        var student = new Student();
        Console.WriteLine("Student Name = " + student.Name);

        student.Name = "Sani Bello";
        Console.WriteLine("Student Name = " + student.Name);
    }
}