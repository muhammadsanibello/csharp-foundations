using System;

namespace CourseRegistrationSystem
{
    public class Course
    {

        public string CourseTitle { get; private set; }
        public string CourseCode { get; private set; }

        public Course(string title, string code)
        {
            CourseTitle = title;
            CourseCode = code;
        }
    }
}
