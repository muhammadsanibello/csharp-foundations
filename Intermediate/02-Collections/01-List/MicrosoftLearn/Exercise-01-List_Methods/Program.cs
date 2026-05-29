// Example: Adding, removing, and iterating through a List<T>

// Define the type T as string for this list
List<string> books = new List<string>(); // T is a string
books.Add("Book A");
books.Add("Book B");
books.Add("Book B");
books.Remove("Book A"); // Remove a specific string from the list

foreach (string book in books)
{
    Console.WriteLine(book);
}
Console.WriteLine(books.Count);