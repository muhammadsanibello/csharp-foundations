class TextEditor
{
    private Stack<string> stack;
    private Queue<string> queue;

    public TextEditor()
    {
        stack = new Stack<string>();
        queue = new Queue<string>();
    }

    // Make a change (e.g., edit text, insert image, change font)
    public void MakeChange(string action)
    {
        stack.Push(action);  // Add to the stack of actions
    }

    // Undo the most recent change
    public string UndoChange()
    {
        if(stack.Count == 0)
        {
            return "No change to undo!";
        }
        return stack.Pop();  // Remove the last action from the stack
    }

    // Add a document to the queue for printing
    public void AddToPrint(string doc)
    {
        queue.Enqueue(doc);
    }

    // Print the document that has been waiting the longest
    public string PrintDoc()
    {
        if (queue.Count == 0)
        {
            return "No documents in print queue!";
        }
        return queue.Dequeue();  // Remove the first document from the queue
    }
}

// Use our text editor!
class Program
{
    static void Main()
    {
        var editor = new TextEditor();
        editor.MakeChange("Changed font size");  // Make a change
        editor.MakeChange("Inserted image");  // Make another change

        // Let's undo a change. It should be the last change we made
        Console.WriteLine($"Undo: {editor.UndoChange()}");  // Undo: Inserted image

        editor.AddToPrint("Proposal.docx");  // Queue a document for printing
        editor.AddToPrint("Report.xlsx");  // Queue another document

        // Let's print a document. It should be the  document that has been waiting the longest.
        Console.WriteLine($"Print: {editor.PrintDoc()}");
    }
}