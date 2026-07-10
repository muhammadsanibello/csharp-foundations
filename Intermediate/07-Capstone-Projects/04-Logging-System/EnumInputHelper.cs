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

            int choice = int.Parse(Console.ReadLine());

            return values[choice - 1];
        }
    }
}