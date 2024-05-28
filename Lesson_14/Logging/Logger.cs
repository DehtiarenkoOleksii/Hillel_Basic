using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public static class Logger
    {
        private static LogEntry[] logEntries = new LogEntry[0]; 

       // Method for adding new log to array
        public static void AddLog(string message)
        {
            Array.Resize(ref logEntries, logEntries.Length + 1);
            logEntries[logEntries.Length - 1] = new LogEntry(message);
        }

        // Get all llogs from array
        public static LogEntry[] GetLogs()
        {
            return logEntries;
        }
    }
}
