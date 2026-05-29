var students = new Dictionary<int, string>
{
    {101, "Ji-Min Jo" },
    {102, "Catalina Blaga" }
};

students.Add(103, "Milan Golob"); // Add a new key-value pair

// Iterate through key-value pairs
foreach (var kvp in students)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Retrieving values
var student = students[101];
Console.WriteLine(student);