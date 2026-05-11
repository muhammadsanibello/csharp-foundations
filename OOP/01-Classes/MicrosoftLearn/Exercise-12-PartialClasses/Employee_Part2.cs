using System;

namespace Exercise_12_PartialClasses
{
    // This is in Employee_Part2.cs
    public partial class Employee
    {
        partial class Part1 { }
        public void GoToLunch()
        {
            Console.WriteLine("Employee is at lunch.");
        }
    }
}

// Another partial class
public partial class Coords
{
    public void PrintCoord()
    {
        Console.WriteLine("Coords: {0},{1}", x, y);
    }
}