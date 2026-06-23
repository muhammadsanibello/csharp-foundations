using Contact_Manager;

Console.WriteLine("===== CONTACT MANAGER =====");

Console.WriteLine(Environment.NewLine);
Console.WriteLine("1. Add Contact");
Console.WriteLine("2. View Contacts");
Console.WriteLine("3. Search Contact");
Console.WriteLine("4. Delete Contact");
Console.WriteLine("5. Save Contacts");
Console.WriteLine("6. Load Contacts");
Console.WriteLine("0. Exit");

// Contact Manager object
ContactManager manager = new ContactManager();

while (true)
{
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("Select from the options above:");

    // Prompt the user for option
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input) || !input.All(char.IsDigit))
    {
        Console.WriteLine("Invalid option! Try again");
        continue;
    }

    if (input == "0")
    {
        return;
    }

    try
    {
        switch (input)
        {
            case "1":
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Phone Number: ");
                string? phone = Console.ReadLine();
                Console.Write("Email: ");
                string? email = Console.ReadLine();

                manager.AddContact(new Contact(name, new PhoneNumber(phone), new Email(email)));
                Console.WriteLine("Contact Saved Successfully");
                break;

            case "2":
                manager.DisplayContacts();
                break;

            case "3":
                Console.Write("Enter Name: ");
                input = Console.ReadLine();

                var contact = manager.SearchContact(input);

                if (contact is null)
                {
                    Console.WriteLine("Contact not found");
                    return;
                }

                Console.WriteLine("Contact Found\n");
                Console.WriteLine(contact);
                break;

            case "4":
                Console.Write("Enter Name: ");
                input = Console.ReadLine();

                bool deleteSuccess = manager.DeleteContact(input);

                if (deleteSuccess)
                {
                    Console.WriteLine("Contact deleted successfully");
                }
                else
                {
                    Console.WriteLine("Contact doesn`t exist");
                }
                break;

            case "5":
                manager.SaveToFile();
                break;

            case "6":
                manager.LoadFromFile();
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }

}