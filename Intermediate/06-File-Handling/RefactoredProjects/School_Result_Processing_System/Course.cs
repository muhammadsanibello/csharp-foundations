using System;

namespace School_Result_Processing_System
{
    public class Course
    {
        public string CourseCode { get; private set; }
        public string CourseTitle { get; private set; }
        public int CreditUnit { get; private set; }

        public Course(string code, string title, int unit)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException("Cannot be empty");

            if (unit <= 0) throw new ArgumentOutOfRangeException(nameof(unit), "Credit unit must be greater than zero");

            CourseCode = code;
            CourseTitle = title;
            CreditUnit = unit;
        }

        public override string ToString()
        {
            return $"Course Title: {CourseTitle}\nCourse Code: {CourseCode}\nCourse Units: {CreditUnit}\n";
        }
    }
}
