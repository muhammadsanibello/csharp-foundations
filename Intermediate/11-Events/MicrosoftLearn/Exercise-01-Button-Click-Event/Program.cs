public class Button
{
    public event EventHandler? Selected;  // Nullable to indicate no subscribers initially

    public void OnClick()
    {
        // If subscribers exist, ?.Invoke syntax triggers an event
        Selected?.Invoke(this, EventArgs.Empty);
    }
}


public class Program
{
    static void Main()
    {
        // Subscribing to the event
        Button button = new Button();
        button.Selected += (sender, e) => Console.WriteLine("Button Selected");

        // Triggering the event
        button.OnClick();
    }
}