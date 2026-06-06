using System;

namespace School_Result_Processing_System
{
    public class Result
    {
        public Course Course { get; }
        public double Score { get; }
        public Grade Grade { get; private set; }
        public int GradePoint { get; private set; }

        public Result(Course course, double score)
        {
            if (course is null) throw new ArgumentException(nameof(course), "Cannot be null");

            if (score > 100) throw new ArgumentOutOfRangeException(nameof(score), "Score is out of range. ( <= 100)");

            Course = course;
            Score = score;

            switch (Score)
            {
                case <= 39:
                    Grade = Grade.F;
                    break;
                case <= 44:
                    Grade = Grade.E;
                    break;
                case <= 49:
                    Grade = Grade.D;
                    break;
                case <= 59:
                    Grade = Grade.C;
                    break;
                case <= 69:
                    Grade = Grade.B;
                    break;
                case <= 100:
                    Grade = Grade.A;
                    break;
                default:
                    throw new InvalidOperationException(nameof(Score));
            }

            switch (Grade)
            {
                case Grade.A:
                    GradePoint = 5;
                    break;
                case Grade.B:
                    GradePoint = 4;
                    break;
                case Grade.C:
                    GradePoint = 3;
                    break;
                case Grade.D:
                    GradePoint = 2;
                    break;
                case Grade.E:
                    GradePoint = 1;
                    break;
                case Grade.F:
                    GradePoint = 0;
                    break;
                default:
                    throw new InvalidOperationException(nameof(Grade));
            }
       
        }
    }
}