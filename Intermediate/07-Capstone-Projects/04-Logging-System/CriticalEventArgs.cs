using System;

namespace LoggingSystem
{
    public class CriticalEventArgs : EventArgs
    {
        public LogEntry LogEntry {  get; private set; }

        public CriticalEventArgs(LogEntry logEntry)
        {
            LogEntry = logEntry;
        }
    }
}
