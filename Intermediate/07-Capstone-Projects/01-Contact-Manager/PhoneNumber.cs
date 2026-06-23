using System;

namespace Contact_Manager
{
    public readonly struct PhoneNumber
    {
        public string Value { get; }

        public PhoneNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value) ||
                value.Length != 11 ||
                !value.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid phone number");
            }

            Value = value;
        }

        public override string ToString() => Value;
    }
}
