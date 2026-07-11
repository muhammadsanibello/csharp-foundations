using System;
using System.Collections.Generic;

namespace LoggingSystem
{
    public class LogManager
    {
        // Dictionary for storing all logs and allow fast lookup by ID
        private Dictionary<string, LogEntry> _logs = new();
        private Stack<LogEntry> _deletedLogs = new();
        private Queue<LogEntry> _pendingLogs = new();

        // Method for creating new log
        public void CreateLog(LogEntry logEntry)
        {
            if (_logs.ContainsKey(logEntry.Id))
            {
                throw new ArgumentException("Log with same Id already exist");
            }

            _logs.Add(logEntry.Id, logEntry);
            _pendingLogs.Enqueue(logEntry);
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
            var log = SearchLog(id);  // return log object if exist, otherwise null

            if (log is null)
            {
                return false;
            }

            _logs.Remove(log.Id);

            // add deleted log to stack
            _deletedLogs.Push(log);

            return true;
        }

        // Method for undo deleted logs
        public bool UndoLog()
        {
            if (_deletedLogs.TryPop(out var restoredLog))
            {
                _logs.Add(restoredLog.Id, restoredLog);

                return true;
            }

            return false;
        }

        // Method for processing logs
        public LogEntry? ProcessNextLog()
        {
            if (_pendingLogs.TryDequeue(out var processedLog))
            {
                return processedLog;
            }

            return null;
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
