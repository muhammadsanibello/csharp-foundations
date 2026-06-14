using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace School_Result_Processing_System
{
    public class Student
    {
        public StudentID StudentId { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Department { get; private set; }
        public int Level { get; }

        private const int _maxCourses = 10;

        private List<Course> _registeredCourses = new();
        private List<Result> _results = new();

        public Student(StudentID studentId, string firstName, string lastName, string department, int level)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(department)) throw new ArgumentNullException("Cannot be empty");

            if (level < 100) throw new ArgumentException(nameof(level), "Invalid level");

            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Level = level;
        }

        public void RegisterCourse(Course inputCourse)
        {
            if (inputCourse is null) throw new ArgumentNullException(nameof(inputCourse), "Cannot be null");

            if (_registeredCourses.Count >= _maxCourses)
            {
                Console.WriteLine("Course registration limit reached.");
                return;
            }

            if (_registeredCourses.Any(x => x.CourseCode == inputCourse.CourseCode))
            {
                throw new InvalidOperationException("Course registration failed! Already registered");
            }

            _registeredCourses.Add(inputCourse);
        }

        public bool DropCourse(Course course)
        {
            // Find the result that matches the course code
            var resultToRemove = _results.SingleOrDefault(x => x.Course.CourseCode == course.CourseCode);

            // If it exists, remove it from the _result collection
            if (resultToRemove != null)
            {
                _results.Remove(resultToRemove);
            }

            // Proceed to remove the course
            return _registeredCourses.Remove(course);
        }

        public void AddResult(Result inputResult)
        {
            if (inputResult is null) throw new ArgumentNullException(nameof(inputResult), "Cannot be null");

            if (!_registeredCourses.Any(x => x.CourseCode == inputResult.Course.CourseCode))
            {
                throw new InvalidOperationException("Attempting to add result to an unregistered course");
            }

            if (_results.Any(x => x.Course.CourseCode == inputResult.Course.CourseCode))
            {
                throw new InvalidOperationException("Addition of result failed! This result already added.");
            }

            _results.Add(inputResult);
        }

        public IEnumerable<Course> GetRegisteredCourses()
        {
            return _registeredCourses;
        }

        public IEnumerable<Result> GetResults()
        {
            return _results;
        }

        public double CalculateGPA()
        {
            int totalGradePoint = _results.Sum(x => x.GradePoint * x.Course.CreditUnit);
            int totalCreditUnits = _results.Sum(x => x.Course.CreditUnit);

            if (totalCreditUnits == 0)
            {
                return 0;
            }

            return totalGradePoint  / (double)totalCreditUnits;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Details:\nStudent ID: {StudentId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nDepartment: {Department}\nCurrent Level: {Level}");
            Console.WriteLine();
        }

        public void DisplayStudentResult()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}\n");
            Console.WriteLine($"Course Code  |  Grade");

            foreach (var result in GetResults())
            {
                Console.Write(result.Course.CourseCode);
                Console.WriteLine($"\t\t{result.Grade}");
            }

            Console.WriteLine($"\nGPA: {CalculateGPA()}");
            Console.WriteLine();
        }
    }
}