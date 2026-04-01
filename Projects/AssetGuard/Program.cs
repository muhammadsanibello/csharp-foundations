Console.WriteLine("---Welcome to AssetGuard---\n");
Console.WriteLine("1- Login\n2- SignUp\n");

string option = Console.ReadLine() ?? "";
while (true)
{
    if (option == "1")
    {
        string password = "12345678";
        Console.WriteLine("Enter Your Password:\n");

        do
        {
            string input = Console.ReadLine() ?? "";
            if (input == password)
            {
                Console.WriteLine("Welcome Back!\n");
                break;
            }

            else
            {
                Console.WriteLine("Wrong Password! - Try again.\n");
                continue;
            }
        } while (true);

        Console.WriteLine("1- Check the status\n2- Report stolen\n");

        do
        {
            string input2 = Console.ReadLine() ?? "";

            if (input2 == "1")
            {
                Console.WriteLine("Your phone is safe as up to date.\n");
                break;
            }

            else if (input2 == "2")
            {
                Console.WriteLine("Sending location...\n");
                break;
            }

            else
            {
                Console.WriteLine("Invalid Input! - Try again\n");
                continue;
            }
        } while (true);

        break;
    }

    else if (option == "2")
    {
        Console.WriteLine("Create an Account.\n");
        Console.Write("\nFirst Name: ");
        string firstName = Console.ReadLine() ?? "";
        Console.Write("\nLast Name: ");
        string lastName = Console.ReadLine() ?? "";
        do
        {
            Console.Write("\nPassword: ");
            string password = Console.ReadLine() ?? "";
            Console.Write("\nConfirm Password: ");
            string confirmPassword = Console.ReadLine() ?? "";

            if (password == confirmPassword)
            {
                string fullName = firstName + " " + lastName;
                Console.WriteLine($"Congratulation! {fullName} - You have successfully created an account.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid! password must match with the second password.");
                continue;
            }
        } while (true);
        break;
    }

    else
    {
        Console.WriteLine("Invalid Input! - Try again.");
        break;
    }

}