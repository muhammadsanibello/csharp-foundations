using System;

namespace Practice
{
    class GPAscoreTable
    {
        public static void Main(string[] args)
        {
            string studentName = "Muhammad Sani Bello";

            // Course Code
            string courseCode1 = "CSC202";
            string courseCode2 = "CSC204";
            string courseCode3 = "CSC206";
            string courseCode4 = "CSC208";
            string courseCode5 = "CSC210";
            string courseCode6 = "CSC220";
            string courseCode7 = "GST212";
            string courseCode8 = "MTH202";
            string courseCode9 = "MTH204";
            string courseCode10 = "PHY202";
            string courseCode11 = "SAZU-CSC222";
            string courseCode12 = "SAZU-CSC224";

            // Course Title
            string courseTitle1 = "Computer Programming II";
            string courseTitle2 = "Computer Architecture & Organization I";
            string courseTitle3 = "Fundamental of Data Structure & Algorithm";
            string courseTitle4 = "Foundation of Sequential Program";
            string courseTitle5 = "Computer Hardware";
            string courseTitle6 = "Operating System I";
            string courseTitle7 = "Philosophy Logic and Human Existence";
            string courseTitle8 = "Elementary Differential Equations";
            string courseTitle9 = "Linear Algebra II";
            string courseTitle10 = "Introduction to Electric Circuits & Electronics";
            string courseTitle11 = "Introduction to Data Science";
            string courseTitle12 = "Introduction to Artificial Intelligence";

            // Course Credit Hours
            int courseCredit1 = 3;
            int courseCredit2 = 2;
            int courseCredit3 = 2;
            int courseCredit4 = 2;
            int courseCredit5 = 2;
            int courseCredit6 = 2;
            int courseCredit7 = 2;
            int courseCredit8 = 2;
            int courseCredit9 = 2;
            int courseCredit10 = 2;
            int courseCredit11 = 2;
            int courseCredit12 = 2;

            // Grade Achieved
            string courseGradeA = "A";
            string courseGradeB = "B";

            string course1Grade = courseGradeB;
            string course2Grade = courseGradeA;
            string course3Grade = courseGradeA;
            string course4Grade = courseGradeA;
            string course5Grade = courseGradeA;
            string course6Grade = courseGradeA;
            string course7Grade = courseGradeB;
            string course8Grade = courseGradeA;
            string course9Grade = courseGradeA;
            string course10Grade = courseGradeA;
            string course11Grade = courseGradeA;
            string course12Grade = courseGradeB;

            // GP or Grade Point
            int courseGP5 = 5;
            int courseGP4 = 4;

            int course1GP = courseGP4;
            int course2GP = courseGP5;
            int course3GP = courseGP5;
            int course4GP = courseGP5;
            int course5GP = courseGP5;
            int course6GP = courseGP5;
            int course7GP = courseGP4;
            int course8GP = courseGP5;
            int course9GP = courseGP5;
            int course10GP = courseGP5;
            int course11GP = courseGP5;
            int course12GP = courseGP4;

            // Total Credit Hours
            int totalCreditHours = 0;

            totalCreditHours += courseCredit1;
            totalCreditHours += courseCredit2;
            totalCreditHours += courseCredit3;
            totalCreditHours += courseCredit4;
            totalCreditHours += courseCredit5;
            totalCreditHours += courseCredit6;
            totalCreditHours += courseCredit7;
            totalCreditHours += courseCredit8;
            totalCreditHours += courseCredit9;
            totalCreditHours += courseCredit10;
            totalCreditHours += courseCredit11;
            totalCreditHours += courseCredit12;

            // Total Grade Point
            int totalGradePoint = 0;

            totalGradePoint += courseCredit1 * course1GP;
            totalGradePoint += courseCredit2 * course2GP;
            totalGradePoint += courseCredit3 * course3GP;
            totalGradePoint += courseCredit4 * course4GP;
            totalGradePoint += courseCredit5 * course5GP;
            totalGradePoint += courseCredit6 * course6GP;
            totalGradePoint += courseCredit7 * course7GP;
            totalGradePoint += courseCredit8 * course8GP;
            totalGradePoint += courseCredit9 * course9GP;
            totalGradePoint += courseCredit10 * course10GP;
            totalGradePoint += courseCredit11 * course11GP;
            totalGradePoint += courseCredit12 * course12GP;

            // Grde Point Average
            decimal gradePointAverage = (decimal)totalGradePoint / totalCreditHours;

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course Code\t\t\tCourse Title\t\t\tCredit Unit(s)\t\tGrade\t\tGP");
            Console.WriteLine($"\n{courseCode1}\t\t{courseTitle1}\t\t\t\t\t{courseCredit1}\t\t{course1Grade}\t\t{course1GP}");
            Console.WriteLine($"{courseCode2}\t\t{courseTitle2}\t\t\t{courseCredit2}\t\t{course2Grade}\t\t{course2GP}");
            Console.WriteLine($"{courseCode3}\t\t{courseTitle3}\t\t{courseCredit3}\t\t{course3Grade}\t\t{course3GP}");
            Console.WriteLine($"{courseCode4}\t\t{courseTitle4}\t\t\t{courseCredit4}\t\t{course4Grade}\t\t{course4GP}");
            Console.WriteLine($"{courseCode5}\t\t{courseTitle5}\t\t\t\t\t{courseCredit5}\t\t{course5Grade}\t\t{course5GP}");
            Console.WriteLine($"{courseCode6}\t\t{courseTitle6}\t\t\t\t\t{courseCredit6}\t\t{course6Grade}\t\t{course6GP}");
            Console.WriteLine($"{courseCode7}\t\t{courseTitle7}\t\t\t{courseCredit7}\t\t{course7Grade}\t\t{course7GP}");
            Console.WriteLine($"{courseCode8}\t\t{courseTitle8}\t\t\t{courseCredit8}\t\t{course8Grade}\t\t{course8GP}");
            Console.WriteLine($"{courseCode9}\t\t{courseTitle9}\t\t\t\t\t{courseCredit9}\t\t{course9Grade}\t\t{course9GP}");
            Console.WriteLine($"{courseCode10}\t\t{courseTitle10}\t\t{courseCredit10}\t\t{course10Grade}\t\t{course10GP}");
            Console.WriteLine($"{courseCode11}\t{courseTitle11}\t\t\t\t{courseCredit11}\t\t{course11Grade}\t\t{course11GP}");
            Console.WriteLine($"{courseCode12}\t{courseTitle12}\t\t\t{courseCredit12}\t\t{course12Grade}\t\t{course12GP}");

            Console.WriteLine($"\nGP: {gradePointAverage}");

            Console.WriteLine("\t\t\t\t\t\t1-12 of 12\n");
        }
    }
}