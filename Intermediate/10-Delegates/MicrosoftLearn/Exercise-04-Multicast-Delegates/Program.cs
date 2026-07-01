using System;

namespace DelegateExamples;

// Define a custom delegate that has a string parameter and return void.
delegate void CustomCallback(string s);

class TestClass
{
    // Define two methods that have the same signature as CustomCallback.
    static void Hello(string s)
    {
        Console.WriteLine($" Hello, {s}");
    }

    static void Goodbye(string s)
    {
        Console.WriteLine($" Goodbye, {s}");
    }

    static void Main()
    {
        // Declare instances of the custom delegate.
        CustomCallback hiDel, byeDel, multiDel, multiMinusHiDel;

        // Instantiate the delegate object hiDel that references the
        // method Hello.
        hiDel = Hello;

        // Instantiate the delegate object byeDel that references the
        // method Goodbye.
        byeDel = Goodbye;

        // The two delegates, hiDel and byeDel, are combined to form multiDel.
        multiDel = hiDel + byeDel;

        // Remove hiDel from the multicast delegate, leaving byeDel,
        // which calls only the method Goodbye.
        multiMinusHiDel = (multiDel - hiDel)!;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("Elize Harmsen");

        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("Mattia Trentini");

        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("Peter Zammit");

        Console.WriteLine("Invoking delegate multiMinusHiDel:");
        multiMinusHiDel("Lennart Kangur");
    }
}