public class Counter
{
    public event EventHandler? ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }

    public void Increment(int value, int threshold)
    {
        if (value >= threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }
}

public class Program
{
    static void Main()
    {
        // Subscribing to the event
        Counter counter = new Counter();
        counter.ThresholdReached += (sender, e) => Console.WriteLine("Threshold reached!");

        // Triggering the event
        counter.Increment(10, 5);
    }
}