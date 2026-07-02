using Capstone_Project;

public class Program
{
    static void Counter_ThresholdReached(object? sender, ThresholdReachedEventArgs e)
    {
        Console.WriteLine($"Threshold of {e.Threshold} reached at {e.TimeReached}");
    }

    static void Main()
    {
        var counter = new Counter(10);

        counter.ThresholdReached += Counter_ThresholdReached;

        Console.WriteLine("Press 'a' to add 1 to the counter or 'q' to quit.");
        while (true)
        {
            var key = Console.ReadKey(true).KeyChar;
            if (key == 'a')
            {
                counter.Add(1);
            }
            else if (key == 'q')
            {
                counter.ThresholdReached -= Counter_ThresholdReached;
                break;
            }
        }
    }
}