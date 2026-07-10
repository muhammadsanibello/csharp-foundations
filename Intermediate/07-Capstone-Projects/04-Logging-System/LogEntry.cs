using System;

namespace LoggingSystem
{
    public class LogEntry
    {
        public string Id { get; }
        public string Message { get; }
        public Level Level { get; }
        public LogSource Source { get; }
        public DateTime DateCreated { get; }

        public LogEntry(string id, string message, Level level, LogSource source, DateTime dateCreated)
        {
            IdValidation.ValidateId(id);

            if (string.IsNullOrWhiteSpace(message)) throw new ArgumentException("Invalid message");

            Id = id;
            Message = message;
            Level = level;
            Source = source;
            DateCreated = dateCreated;
        }

        public override string ToString()
        {
            return $"Log ID: {Id}\nLog Message: {Message}\nError Level: {Level}\nLog Source: {Source}\nDate Created: {DateCreated}\n";
        }
    }
}
