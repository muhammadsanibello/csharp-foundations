// Define a delegate
public delegate void ButtonClickedHandler(object sender, EventArgs e);

// Use the delegate in an event
public class Button
{
    public event ButtonClickedHandler? Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

public class Program
{
    static void Main()
    {
        Button button = new Button();

        button.Clicked += (sender, e) => Console.WriteLine("Button clicked");
        button.OnClick();
    }
}