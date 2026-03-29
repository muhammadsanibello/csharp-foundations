using System;

namespace Program3
{
    class Operations
    {
        public static void Main(string[] args)
        {
            int firstNumber = 20;
            int secondNumber = 30;

            //Implicit type conversion between numeric and string data types 
            Console.WriteLine("Total = " + (firstNumber + secondNumber));

            //Basic math operations
            int add = 50 + 50;
            int subt = 60 - 30;
            int mult = 30 * 10;
            int div = 70 / 6;
            decimal qout = 70.0m / 6;
            Console.WriteLine($"Sum = {add}");
            Console.WriteLine("Difference = " + subt);
            Console.WriteLine("Product = " + mult);
            Console.WriteLine("Quotient = " + div);
            Console.WriteLine($"DecimalQout = {qout}");

            // Casting of integer division
            decimal qoutient = (decimal)firstNumber / (decimal)secondNumber;
            Console.WriteLine(qoutient);

            // Using modulus operator
            int number = 50;
            Console.WriteLine($"The modulus of 50 / 5: {number % 5}");

            // Order of operations
            int value1 = 20 - 50 + 40 * 2;
            Console.WriteLine(value1);

            // Incrementation/Decrementation
            int value2 = 5;
            Console.WriteLine(value2);
            value2 += 10;
            value2++;
            Console.WriteLine(value2);
            int value3 = 0;
            value3 -= 10;
            value3--;
            Console.WriteLine(--value3);

            //Conversion
            int farenheit = 94;
            float celcius = (farenheit - 32) * (5 / 9f);
            Console.WriteLine($"Celcius: {celcius}");
        }
    }
}