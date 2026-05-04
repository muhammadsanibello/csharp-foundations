using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem
{
    public class Student
    {

        public string Name;
        public Course[] listOfCourses;
        public int courseCount;

        public Student(string name)
        {
            Name = name;
            listOfCourses = new Course[10];
            courseCount = 0;
        }

        public void EnrollCourse(Course course)
        {
            if (courseCount < 10)
            {
                listOfCourses[courseCount] = course;
                courseCount++;

                Console.WriteLine($"{Name} enrolled in {course.CourseTitle}");
            }
            else
            {
                Console.WriteLine("Course limit reached!");
            }
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"\nCourses for {Name}:");

            if (courseCount == 0)
            {
                Console.WriteLine("\nNo course registered.");
                return;
            }

            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine($"{listOfCourses[i].CourseTitle} ({listOfCourses[i].CourseCode})");
            }
        }
    }
}
