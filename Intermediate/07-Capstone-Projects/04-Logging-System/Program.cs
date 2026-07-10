using LoggingSystem;
using System.Text.Json;

var menu = Menu.GetUserMenu();
string? input = string.Empty;
var manager = new LogManager();

while (input != "0")
{
    Console.WriteLine(menu);
    Console.WriteLine(Environment.NewLine);

    Console.Write("Choose from the above options to continue: ");
    input= Console.ReadLine();
    MenuOptionValidation.ValidateOption(input);

    switch (input)
    {
        case "1":  // Create a log object

            Console.Write("Enter Log ID: ");
            string? id = Console.ReadLine();

            Console.Write("Enter Log message: ");
            string? message = Console.ReadLine();

            Console.WriteLine("Select an error level:");
            Level level = EnumInputHelper.GetEnumChoice<Level>();

            Console.WriteLine("Select a log source:");
            LogSource logSource = EnumInputHelper.GetEnumChoice<LogSource>();

            manager.CreateLog(new LogEntry(id, message, level, logSource, DateTime.Now));

            break;

        case "2":  // View logs

            Console.WriteLine("===== Available logs =====\n");

            foreach (var log in manager.GetAllLogs())
            {
                Console.WriteLine(log);
            }

            break;

        case "3":  // Search a log

            Console.Write("Enter a log ID: ");
            input = Console.ReadLine();

            var targetLog = manager.SearchLog(input);

            if (targetLog is null)
            {
                Console.WriteLine($"Log with Id {input} doesn't exist\n");
                break;
            }

            Console.WriteLine("==== Log Details ====\n");
            Console.WriteLine(targetLog);

            break;

        case "4":   // Delete a log

            Console.Write("Enter a log ID: ");
            input = Console.ReadLine();

            var removeSuccess = manager.DeleteLog(input);

            if (!removeSuccess)
            {
                Console.WriteLine($"No Log with such ID exist.\n");
                break;
            }

            Console.WriteLine($"Success! Log with ID {input} deleted\n");

            break;

        case "5":  // Statistics

            Console.WriteLine("\n===== Statistics Dashboard =====\n");

            var logs = manager.GetAllLogs();
            int totalLogs = logs.Count();
            int informations = logs.Count(x => x.Level == Level.Information);
            int errors = logs.Count(x => x.Level == Level.Error);
            int warnings = logs.Count(x => x.Level == Level.Warning);
            int critical = logs.Count(x => x.Level == Level.Critical);

            Console.WriteLine($"Total Logs: {totalLogs}\nInformations: {informations}\nErrors: {errors}\nWarnings: {warnings}\nCritical: {critical}\n");
            break;
    }
}