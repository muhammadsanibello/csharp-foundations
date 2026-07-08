using System;

namespace LoggingSystem
{
    public static class IdValidation
    {
        public static void ValidateId(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || !id.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid Id");
            }
        }
    }
}
