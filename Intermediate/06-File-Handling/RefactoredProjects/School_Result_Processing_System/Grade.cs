using System;

namespace School_Result_Processing_System
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    public static class GradeExtensions
    {
        public static string GetGradeDescription(this Grade grade)
        {
            return grade switch
            {
                Grade.A => "Excellence! 70 - 100 score range. (PASSED)",
                Grade.B => "Very Good! 60 - 69 score range. (PASSED)",
                Grade.C => "Credit! 50 - 59 score range. (PASSED)",
                Grade.D => "Fair! 45 - 49 score range. (PASSED)",
                Grade.E => "Pass! 40 - 44 score range. (PASSED)",
                Grade.F => "Poor! 0 - 39 score range. (FAILED)",
                _ => "Unkown grade",
            };
        }
    }
}
