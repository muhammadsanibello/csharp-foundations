// Private Class Constructors

class NLOg
{
    // Private Constructor
    private NLOg() { }   // Preventing the creation of instance of this class
                         // when there are no instance fields or methods

    public static double e = Math.E;  // 2.71828...
}

// Another Example
public class Counter
{
    private Counter() { }

    public static int currentCount;

    public static int IcrementCount()
    {
        return ++currentCount;
    }
}

class TestCounter
{
    static void Main()
    {
        //Counter counter1 = new Counter();

        Counter.currentCount = 100;
        Counter.IcrementCount();
        Console.WriteLine("New count: {0}", Counter.currentCount);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}