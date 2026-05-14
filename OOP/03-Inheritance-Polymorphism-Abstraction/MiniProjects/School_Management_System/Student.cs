using System;

namespace School_Management_System
{
    public class Student : Person
    {
        public string Department { get; private set; }
        public double CGPA { get; private set; }

        private Course[] _registerCourses;

        private int _courseCount;
        public static int MaxCourses { get; } = 10;

        public Student(string firstName, string lastName, int age, string department, double cgpa) : base(firstName, lastName, age)
        {
            if (string.IsNullOrEmpty(department)) throw new ArgumentNullException(nameof(department), "Cannot be empty.");

            if (cgpa < 0 || cgpa > 5) throw new ArgumentOutOfRangeException(nameof(cgpa), "Must be in range of 0 - 5");

            Department = department;
            CGPA = cgpa;
            _registerCourses = new Course[MaxCourses];
            _courseCount = 0;
        }

        public void RegisterCourse(Course course)
        {
            if (_courseCount >= MaxCourses)
            {
                Console.WriteLine("Course registration limit reached");
                return;
            }
            
            for (int i = 0; i < _courseCount; i++)
            {
                if (_registerCourses[i].CourseCode == course.CourseCode)
                {
                    Console.WriteLine("Course already registered");
                    return;
                }

            }

            _registerCourses[_courseCount] = course;
            _courseCount++;
            Console.WriteLine($"Success! {course.CourseTitle} registered successfully.");
        }

        public void UnRegisterCourse(Course course)
        {
            for (int i = 0; i < _courseCount; i++)
            {
                if (_registerCourses[i].CourseCode == course.CourseCode)
                {
                    // Shift everything left by one
                    for (int j = i; j < _courseCount - 1; j++)
                    {
                        _registerCourses[j] = _registerCourses[j + 1];
                    }

                    // Clear the last slot
                    _registerCourses[_courseCount - 1] = null;

                    // Decrement the counter
                    _courseCount--;
                    Console.WriteLine($"Success! Unregistered {course.CourseTitle} successfully.");
                    break;
                }
            }
        }

        public void DisplayRegisteredCourses()
        {
            for (int i = 0; i < _courseCount; i++)
            {
                _registerCourses[i].DisplayCourseInfo();
                Console.WriteLine();
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Student Details:\nFirst Name: {0}\nLast Name: {1}\nAge:   {2}\nStudent ID: {3}\nDepartment: {4}\nCGPA:  {5}", FirstName, LastName, Age, ID, Department, CGPA);
            Console.WriteLine();
        }
    }
}
