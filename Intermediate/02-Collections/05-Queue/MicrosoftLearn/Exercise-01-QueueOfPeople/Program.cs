class QueueOfPeople
{
    private Queue<string> queue;

    public QueueOfPeople()
    {
        queue = new Queue<string>();
    }

    // Add person to the end of the queue
    public void EnqueuePerson(string person)
    {
        queue.Enqueue(person);
    }

    // Remove the first person from the queue (who has been waiting the longest)
    public string DequeuePerson()
    {
        if (queue.Count == 0)
        {
            return "No people left to dequeue";
        }
        return queue.Dequeue();
    }
}

// Create a queue of people
class Program
{
    static void Main()
    {
        var people = new QueueOfPeople();

        people.EnqueuePerson("Person 1");  // Person 1 enters the queue
        people.EnqueuePerson("Person 2");  // Person 2 arrives after Person 1

        // Who's next in line? It must be Person 1!
        Console.WriteLine($"Removed: {people.DequeuePerson()}");
    }
}