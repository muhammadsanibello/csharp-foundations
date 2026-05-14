using System;

namespace School_Management_System
{
    public class Teacher : Person
    {
        private decimal _salary;

        public Course[] CourseTeaching { get; private set; }

        public static int MaxCourseTeaching { get; } = 3;

        private int _courseCount;

        public Teacher(string firstName, string lastName, int age, decimal salary) : base(firstName, lastName, age)
        {

            if (salary <= 0) throw new ArgumentException(nameof(salary), "Must be greater than zero");

            _salary = salary;
            CourseTeaching = new Course[MaxCourseTeaching];
            _courseCount = 0;

        }

        public void AssignCourse(Course course)
        {
            if (_courseCount >= MaxCourseTeaching)
            {
                Console.WriteLine("Course limit reached");
                return;
            }

            for (int i = 0; i < _courseCount; i++)
            {
                if (CourseTeaching[i].CourseCode == course.CourseCode)
                {
                    Console.WriteLine("Course already assigned");
                    return;
                }
            }

            CourseTeaching[_courseCount] = course;
            _courseCount++;
            Console.WriteLine($"Success! {course.CourseTitle} assigned successfully");
        }

        public void UnAssignCourse(Course course)
        {
            for (int i = 0; i < _courseCount; i++)
            {
                if (CourseTeaching[i].CourseCode == course.CourseCode)
                {
                    // Shift everything left by one
                    for (int j = i; j < _courseCount - 1; j++)
                    {
                        CourseTeaching[j] = CourseTeaching[j + 1];
                    }

                    // Clear the last slot
                    CourseTeaching[_courseCount - 1] = null;

                    // Decrement the counter
                    _courseCount--;
                    Console.WriteLine($"Success! Unassigned {course.CourseTitle} successfully.");
                    break;
                }
            }
        }

        public void DisplayAssignedCourses()
        {
            for (int i = 0; i < _courseCount; i++)
            {
                CourseTeaching[i].DisplayCourseInfo();
                Console.WriteLine();
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Teacher Details:\nFirst Name: {0}\nLast Name: {1}\nAge:   {2}\nTeacher ID: {3}\nSalary:  {4}", FirstName, LastName, Age, ID, _salary);
            Console.WriteLine();
        }
    }

}