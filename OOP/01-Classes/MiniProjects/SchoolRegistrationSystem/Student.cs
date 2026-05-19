using System;

namespace SchoolRegistrationSystem
{
    public class Student
    {

        public string studentName;
        public Course[] listOfCourses;
        public int courseCount;
        public int maxCourses;

        public Student(string name)
        {
            studentName = name;
            listOfCourses = new Course[3];
            courseCount = 0;
            maxCourses = 3;
        }

        public void EnrollCourse(Course course)
        {
            if (courseCount == maxCourses)
            {
                Console.WriteLine("Cannot register more courses");
                return;
            }

            for (int i = 0; i < courseCount; i++)
            {
                if (listOfCourses[i].courseCode == course.courseCode)
                {
                    Console.WriteLine($"{course.courseCode} already registered");
                    return;
                }
            }
            

            listOfCourses[courseCount] = course;
            courseCount++;

            Console.WriteLine($"{studentName} enrolled in {course.courseTitle}");
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"\nCourses for {studentName}:");

            if (courseCount == 0)
            {
                Console.WriteLine("No courses registered");
                return;
            }

            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine($"{listOfCourses[i].courseTitle} ({listOfCourses[i].courseCode})");
            }

        }
    }
}
