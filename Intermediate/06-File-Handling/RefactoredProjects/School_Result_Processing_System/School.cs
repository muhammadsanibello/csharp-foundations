using System;
using System.Collections.Generic;

namespace School_Result_Processing_System
{
    public sealed class School
    {
        public string SchoolName { get; private set; }
        public string Location { get; private set; }

        private Dictionary<StudentID, Student> _students = new();
        private HashSet<Course> _courses = new(); 

        public School(string schoolName, string location)
        {
            if (string.IsNullOrWhiteSpace(schoolName) || string.IsNullOrWhiteSpace(location)) throw new ArgumentNullException("School name or location cannot be empty");

            SchoolName = schoolName;
            Location = location;
        }

        public void AdmitStudent(Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student), "Cannot be null");

            if (_students.ContainsKey(student.StudentId)) throw new ArgumentException("Student already admitted");

            _students.Add(student.StudentId, student);
        }

        public void AddCourse(Course course)
        {
            if (course is null) throw new ArgumentNullException(nameof(course), "Cannot be null");

            _courses.Add(course);
        }

        public Student FindStudent(StudentID studentID)
        {
            if (_students.TryGetValue(studentID, out var student))
            {
                return student;
            }

            throw new InvalidOperationException($"No student exist with ID {studentID}");
        }

        public void DisplayAllStudent()
        {
            Console.WriteLine("---Available Students---");

            if (_students.Count == 0)
            {
                Console.WriteLine("No student Available");
                return;
            }

            foreach (var student in _students)
            {
                student.Value.DisplayStudentInfo();
            }
        }
    }
}