using System;

namespace CourseRegistrationSystem
{
    public class Course
    {

        public string CourseTitle;
        public string CourseCode;

        public Course(string title, string code)
        {
            CourseTitle = title;
            CourseCode = code;
        }
    }
}
