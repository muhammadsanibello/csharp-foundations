using System;

namespace DecoupleWithInterfaces
{
    public class Student : IPerson, IComparable
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } = 0;

        public string Role => "Student";

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}");
        }

        public int CompareTo(Object? obj)
        {
            // Explicitly check if obj is null
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Cannot compare to a null object.");
            }

            // cast obj to Student with pattern matching
            if(obj is Student other)
            {
                // Compare the Age property
                return this.Age.CompareTo(other.Age);
            }
            else
            {
                throw new ArgumentException(nameof(obj), "The object being compared must be of type Student.");
            }
            
        }
    }
}
