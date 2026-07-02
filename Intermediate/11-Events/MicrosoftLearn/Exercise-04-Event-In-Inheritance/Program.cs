public class BaseCounter
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

public class AdvancedCounter : BaseCounter
{
    protected override void OnThresholdReached(EventArgs e)
    {
        Console.WriteLine("Advanc\edCounter: Threshold reached!");
        base.OnThresholdReached(e);
    }
}

public class Program
{
    static void Main()
    {
        // Usage
        AdvancedCounter counter = new AdvancedCounter();
        counter.ThresholdReached += (sender, e) => Console.WriteLine("Subscriber: Threshold reached!");
        counter.Increment(10, 5);
    }
}