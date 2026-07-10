using System;

namespace LoggingSystem
{
    public static class MenuOptionValidation
    {
        public static void ValidateOption(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || !input.All(Char.IsDigit))
            {
                throw new ArgumentException("Invalid option! Try-again");
            }
        }
    }
}
