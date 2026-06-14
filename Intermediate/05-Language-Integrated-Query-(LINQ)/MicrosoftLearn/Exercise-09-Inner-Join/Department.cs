using System;

namespace StandardQueryOperators
{
    public class Department
    {
        public required string Name { get; init; }
        public int ID { get; init; }

        public required int TeacherID { get; init; }
    }
}