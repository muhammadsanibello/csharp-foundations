using Todo_App;

Console.WriteLine("===== TO-DO APP =====");

Console.WriteLine(Environment.NewLine);
Console.WriteLine("1.  Add Task");
Console.WriteLine("2.  View Tasks");
Console.WriteLine("3.  Search Task");
Console.WriteLine("4.  Mark Task as Completed");
Console.WriteLine("5.  Delete Task");
Console.WriteLine("6.  Save Task");
Console.WriteLine("7.  Load Task");
Console.WriteLine("8.  Display Pending Tasks");
Console.WriteLine("9.  Display Completed Tasks");
Console.WriteLine("10. Display Tasks Statistics");
Console.WriteLine("0.  Exit");

// Task Manger object
TaskManager manager = new TaskManager();

bool validInput = false;
string input = string.Empty;

while (true)
{
    Console.WriteLine(Environment.NewLine);
    Console.Write("Choose from the option above: ");

    input = Console.ReadLine() ?? "";

    validInput = UtilityClass.ValidateInput(input);

    if (!validInput)
    {
        Console.WriteLine("Invalid option! Try again.");
        continue;
    }

    if (input == "0")
    {
        Console.WriteLine("Exitted");
        return;
    }

    try
    {
        switch (input)
        {
            case "1":

                // Add task
                Console.Write("Enter task ID: ");
                string taskId = Console.ReadLine() ?? "";

                Console.Write("Enter task title: ");
                string title = Console.ReadLine() ?? "";

                Console.Write("Enter task description: ");
                string description = Console.ReadLine() ?? "";

                manager.AddTask(new TaskItem(taskId, title, description));
                break;

            case "2":

                // View tasks
                Console.WriteLine("\nList of Tasks:\n");

                if (!manager.GetTaskItems().Any())
                {
                    Console.WriteLine("No Task Available");
                    break;
                }

                foreach (var task in manager.GetTaskItems())
                {
                    Console.WriteLine(task);
                }

                break;

            case "3":

                // Search a task
                Console.Write("Enter task ID: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid ID! Try-again");
                    break;
                }

                var foundTask = manager.SearchTask(input);
                
                if (foundTask is null)
                {
                    Console.WriteLine("Task not found");
                    break;
                }

                Console.WriteLine(foundTask);

                break;

            case "4":

                // Mark task complete
                Console.Write("Enter task ID: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid ID! Try-again");
                    break;
                }

                bool markSuccess = manager.MarkTaskCompleted(input);

                if (!markSuccess)
                {
                    Console.WriteLine($"No task with id {input} found");
                    break;
                }

                Console.WriteLine("Mark to 'completed' successfully");

                break;

            case "5":

                // Delete task
                Console.Write("Enter task ID: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid ID! Try-again");
                    break;
                }

                bool removeSuccess = manager.DeleteTask(input);

                if (!removeSuccess)
                {
                    Console.WriteLine($"No task with id {input} found");
                    break;
                }

                Console.WriteLine("Task deleted successfully");

                break;

            case "6":

                // Save to a file
                manager.SaveToFile();
                Console.WriteLine("Saved Successfully");
                break;

            case "7":

                // Load from a file
                manager.LoadFile();
                Console.WriteLine("Loaded successfulyy");
                break;

            case "8":

                // Display Pending tasks
                Console.WriteLine("\nList of Pending Tasks:\n");

                if (!manager.GetPendingTaskItems().Any())
                {
                    Console.WriteLine("No Pending task available");
                    break;
                }

                foreach (var task in manager.GetPendingTaskItems())
                {
                    Console.WriteLine(task);
                }

                break;

            case "9":

                // Display Completed tasks
                Console.WriteLine("\nList of Completed Tasks:\n");

                if (!manager.GetCompletedTaskItems().Any())
                {
                    Console.WriteLine("No Completed task available");
                    break;
                }

                foreach (var task in manager.GetCompletedTaskItems())
                {
                    Console.WriteLine(task);
                }

                break;

            case "10":

                // Display Tasks Statistics
                Console.WriteLine("\n==== Tasks Statistics ====\n");

                if (!manager.GetTaskItems().Any())
                {
                    Console.WriteLine("No Task Available");
                    break;
                }

                int totalTasks = manager.GetTaskItems().Count(); ;
                int pendingTasks = manager.GetPendingTaskItems().Count();
                int completedTasks = manager.GetCompletedTaskItems().Count();

                Console.WriteLine($"Total Tasks: {totalTasks}");
                Console.WriteLine($"Pending:     {pendingTasks}");
                Console.WriteLine($"Completed:   {completedTasks}");

                break;

            default:
                throw new ArgumentException("Option doesn`t exist");
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