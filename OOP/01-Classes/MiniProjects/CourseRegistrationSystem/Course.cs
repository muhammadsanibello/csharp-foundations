using System;
using System.Collections.Generic;
using System.Text;

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
