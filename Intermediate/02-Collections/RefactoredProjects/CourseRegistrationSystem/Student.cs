using System;

namespace CourseRegistrationSystem
{
    public class Student
    {

        public string Name { get; private set; }

        private HashSet<Course> _registeredCourses;

        public Student(string name)
        {
            Name = name;
            _registeredCourses = new HashSet<Course>();
        }

        public void EnrollCourse(Course course)
        {
            _registeredCourses.Add(course);
        }

        public void DropCourse(Course course)
        {
            if (!_registeredCourses.Contains(course))
            {
                Console.WriteLine($"{course.CourseTitle} was not registered already");
                return;
            }

            _registeredCourses.Remove(course);
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"\nCourses for {Name}:");

            if (_registeredCourses.Count == 0)
            {
                Console.WriteLine("No registered courses.");
                return;
            }

            foreach (Course course in _registeredCourses)
            {
                Console.WriteLine($"{course.CourseTitle} ({course.CourseCode})");
            }
        }
    }
}
