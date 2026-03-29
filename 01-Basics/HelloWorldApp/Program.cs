using System;

namespace Program
{
    class Practice
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the first line.");
            Console.WriteLine("This is the second line.");
            Console.WriteLine('O');
            Console.WriteLine(12345);
            Console.WriteLine(0.54f);
            Console.WriteLine(0.543);
            Console.WriteLine(0.9860m);
            Console.WriteLine(true);
            string schoolName;
            schoolName = "Ummul-Qura Science Academy Azare";
            Console.WriteLine(schoolName);
            schoolName = "Sa`adu Zungur University";
            Console.WriteLine(schoolName);
            string firstName = "Bob";
            int messages;
            messages = 3;
            float temperature;
            temperature = 34.4f;
            string finalMessage;
            finalMessage = "Hello, " + firstName + "! You have " + messages + " " + "messages in your inbox. The temperature is " + temperature + " celsius.";
            Console.WriteLine(finalMessage);
            Console.WriteLine("Hello!\t \"MUhammad\"");
            Console.WriteLine("c:\\source\repos");
            Console.WriteLine("Generating invoices for customer \"Muhammad\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.WriteLine(@"c:\invoices");
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");
        }
    }
}