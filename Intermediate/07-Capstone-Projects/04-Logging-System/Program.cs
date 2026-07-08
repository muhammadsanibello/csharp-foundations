using LoggingSystem;
using System.Text.Json;

var manager = new LogManager();

manager.CreateLog(new LogEntry("12", "Database Connection Error", Level.Error, LogSource.Database, DateTime.Now));
manager.CreateLog(new LogEntry("13", "Payment processing failed", Level.Error, LogSource.Payment, DateTime.Now));

var repository = new LogRepository();
await repository.SaveLogsAsync(manager);

var jsonString = await repository.LoadLogsAsync();
var logObjects = JsonSerializer.Deserialize<List<LogEntry>>(jsonString) ?? throw new InvalidOperationException("Failed to deserialize json string");

manager.ClearLog();

foreach (var logObject in logObjects)
{
    manager.CreateLog(logObject);
}