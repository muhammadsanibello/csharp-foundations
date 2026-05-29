HashSet<string> emailAddresses = new HashSet<string>();

// Add items
emailAddresses.Add("user1@example.com");
emailAddresses.Add("user2@example.com");
emailAddresses.Add("user1@example.com"); // Duplicate, won't be added

// Iterate through collection
foreach (string email in emailAddresses)
{
    Console.WriteLine(email);
}