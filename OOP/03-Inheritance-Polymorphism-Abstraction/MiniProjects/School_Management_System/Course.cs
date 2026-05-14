using System;

namespace School_Management_System
{
    public class Course
    {
        public string CourseTitle { get; private set; }
        public string CourseCode { get; private set; }
        public int CourseUnit { get; private set; }

        public Course(string title, string code, int unit)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException(nameof(title), "Cannot be empty.");

            if (string.IsNullOrEmpty(code)) throw new ArgumentNullException(nameof(code), "Cannot be empty.");

            if (code.Length != 6) throw new ArgumentException(nameof(code), "Length must be 6");

            if (unit <= 0 || unit > 10) throw new ArgumentOutOfRangeException(nameof(unit), "Must be in range of 1 - 10");

            CourseTitle = title;
            CourseCode = code;
            CourseUnit = unit;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine("Course Details:\nCourse Title: {0}\nCourse Code: {1}\nCourse Unit: {2}", CourseTitle, CourseCode, CourseUnit);
            Console.WriteLine();
        }
    }
}
