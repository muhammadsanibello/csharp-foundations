using System;

namespace LoggingSystem
{
    public static class EnumInputHelper
    {
        public static T GetEnumChoice<T>() where T : Enum
        {
            var values = (T[])Enum.GetValues(typeof(T));

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {values[i]}");
            }

            int choice;

            while (!int.TryParse(Console.ReadLine(),
                out choice) || 
                choice < 1 || 
                choice > values.Length)
            {
                Console.WriteLine("Invalid choice. Try again:");
            }

            return values[choice - 1];
        }
    }
}