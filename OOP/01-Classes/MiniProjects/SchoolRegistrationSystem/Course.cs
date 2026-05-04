using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegistrationSystem
{
    public class Course
    {

        public string courseTitle;
        public string courseCode;

        public Course(string title, string code)
        {
            courseTitle = title;
            courseCode = code;
        }
    }
}
