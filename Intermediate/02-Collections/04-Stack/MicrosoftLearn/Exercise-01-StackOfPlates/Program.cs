class StackOfPlates
{
    private Stack<string> stack;

    public StackOfPlates()
    {
        stack = new Stack<string>();
    }

    // Insert a plate at the top of the stack
    public void AddPlate(string plate)
    {
        stack.Push(plate);
    }

    // Remove the top plate from the stack
    public string RemovePlate()
    {
        if (stack.Count == 0)
        {
            return "No plates left to remove!";
        }
        return stack.Pop();
    }
}

// Create a stack of plates
class Program
{
    static void Main()
    {
        var plates = new StackOfPlates();

        plates.AddPlate("Plate");  // Push a plate
        plates.AddPlate("Another Plate");  // Push another plate

        // Let`s remove a plate; it should be last one we added
        Console.WriteLine($"Removed: {plates.RemovePlate()}");  // Output: Removed: Another Plate
    }
}