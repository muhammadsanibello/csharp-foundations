using System;
using System.Text.Json;

namespace LoggingSystem
{
    public class LogRepository
    {   
        // Method of saving logs to a file
        public async Task SaveLogsAsync(LogManager manager)
        {
            // customize the Serialize() method
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            var logObjects = manager.GetAllLogs();
            string jsonString = JsonSerializer.Serialize(logObjects, options);

            await File.WriteAllTextAsync(FileSource.GetFilePath(), jsonString);
        }

        // Method of loading logs from the file
        public async Task<string> LoadLogsAsync()
        {
            var jsonString = await File.ReadAllTextAsync(FileSource.GetFilePath());
            return jsonString;

        }
    }
}