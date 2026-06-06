using System;

namespace School_Result_Processing_System
{
    public readonly struct StudentID
    {
        public string Value { get; }

        public StudentID(string value)
        {
            if (value is null || value.Length != 10 || !value.StartsWith("UG"))
                throw new ArgumentException(nameof(value), "Invalid ID");

            Value = value;
        }

        public override string ToString() => Value;
    }
}
