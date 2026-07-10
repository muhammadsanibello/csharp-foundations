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
        case "1":

            Console.Write("Enter Log ID: ");
            string? id = Console.ReadLine();

            Console.Write("Enter Log message: ");
            string? message = Console.ReadLine();

            Level level = EnumInputHelper.GetEnumChoice<Level>();
            LogSource logSource = EnumInputHelper.GetEnumChoice<LogSource>();

            manager.CreateLog(new LogEntry(id, message, level, logSource, DateTime.Now));

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