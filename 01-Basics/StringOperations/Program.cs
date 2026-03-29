using System;

namespace Program2
{
    class FormString
    {
        public static void Main(string[] args)
        {
            string greeting = "Hello";
            string fullName = "Muhammad Sani Bello";

            // Traditional Concatenation method
            Console.WriteLine(greeting + " " + fullName + "!");

            // Concise method (string interpolation)
            Console.WriteLine($"{greeting} {fullName}! \n");

            // Another interpolation example
            Console.WriteLine($"Guru {fullName}! \n");

            //Combine String and another type using interpolation 
            int version = 11;
            string updates = "Update to version";
            Console.WriteLine($"{updates} {version}! \n");
            Console.WriteLine(@$"c\output\{version}\Data");

            //Challenge
            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine(@$"View English output: 
   c:\Exercise\{projectName}\data.txt");

            Console.WriteLine($@"{russianMessage}:
   c:\Exercise\ACME\ru-RU\data.txt");

        }
    }
}
