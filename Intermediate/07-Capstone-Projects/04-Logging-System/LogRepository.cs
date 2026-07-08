using System;
using System.Text.Json;

namespace LoggingSystem
{
    public class LogRepository
    {
        // Method of saving logs to a file
        public async Task SaveLogsAsync(LogManager manager)
        {
            var logObjects = manager.logEntries();
            string JsonString = JsonSerializer.Serialize(logObjects);

            await File.WriteAllTextAsync(FileSource.GetFilePath(), JsonString);
        }

        // Method of loading logs from the file
        public async Task<string> LoadLogsAsync()
        {
            var jsonString = await File.ReadAllTextAsync(FileSource.GetFilePath());
            return jsonString;

        }
    }
}