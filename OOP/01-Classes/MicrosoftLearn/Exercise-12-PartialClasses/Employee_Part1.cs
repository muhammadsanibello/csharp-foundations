using System;

namespace Exercise_12_PartialClasses
{
    // This is in Employee_Part1.cs
    public partial class Employee
    {
        partial class Part1 { }
        public void DoWork()
        {
            Console.WriteLine("Employee is working.");
        }
    }
}

// Another partial class
public partial class Coords
{
    private int x;
    private int y;

    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}