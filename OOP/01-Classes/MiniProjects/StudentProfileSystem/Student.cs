using System;

namespace StudentProfileSystem
{
    public class Student
    {
        public string Name;
        public int Age;
        public string Department;

        public Student(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student: Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}