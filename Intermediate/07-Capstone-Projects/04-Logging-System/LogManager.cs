using System;
using System.Collections.Generic;

namespace LoggingSystem
{
    public class LogManager
    {
        // Dictionary for storing all logs and allow fast lookup by ID
        private Dictionary<string, LogEntry> _logs = new();

        // Method for creating new log
        public void CreateLog(LogEntry logEntry)
        {
            if (_logs.ContainsKey(logEntry.Id))
            {
                throw new ArgumentException("Log with same Id already exist");
            }

            _logs.Add(logEntry.Id, logEntry);
        }

        // Method for viewing all logs
        public IEnumerable<LogEntry> GetAllLogs()
        {
            if ( _logs.Count == 0)
            {
                throw new ArgumentException("No log available");
            }

            return _logs.Values;
        }

        // Method for Searching log
        public LogEntry? SearchLog(string id)
        {
            IdValidation.ValidateId(id);

            if (_logs.TryGetValue(id, out var logEntry))
            {
                return logEntry;
            }

            return null;
        }

        // Method for deleting a log
        public bool DeleteLog(string id)
        {
            IdValidation.ValidateId(id);

            return _logs.Remove(id);
        }

        // Method for clearing the _log data
        public void ClearLogs()
        {
            if (_logs.Count == 0)
            {
                return;
            }

            _logs.Clear();
        }
    }
}
