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

            if (!manager.logEntries().Any())
            {
                Console.WriteLine("No log available\n");
                break;
            }

            foreach (var log in manager.logEntries())
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

            if (!manager.logEntries().Any())
            {
                Console.WriteLine("No log available\n");
                break;
            }

            int totalLogs = 0;
            int informations = 0;
            int errors = 0;
            int warnings = 0;
            int critical = 0;

            foreach (var log in manager.logEntries())
            {
                if (log.Level == Level.Information)
                {
                    informations++;
                }
                else if (log.Level == Level.Error)
                {
                    errors++;
                }
                else if(log.Level == Level.Warning)
                {
                    warnings++;
                }
                else
                {
                    critical++;
                }

                totalLogs++;

            }

            Console.WriteLine($"Total Logs: {totalLogs}\nErrors: {errors}\nWarnings: {warnings}\nCritical: {critical}\n");
            break;
    }
}

var repository = new LogRepository();
await repository.SaveLogsAsync(manager);

var jsonString = await repository.LoadLogsAsync();
var logObjects = JsonSerializer.Deserialize<List<LogEntry>>(jsonString) ?? throw new InvalidOperationException("Failed to deserialize json string");

manager.ClearLog();

foreach (var logObject in logObjects)
{
    manager.CreateLog(logObject);
}