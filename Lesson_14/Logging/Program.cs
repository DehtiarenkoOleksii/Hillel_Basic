using System;
namespace Logging
{ 
    internal class Program
    {
        static void Main()
        {
            // Add some logs
            Logger.AddLog("System starting");
            Logger.AddLog("Connecting to the internet");
            Logger.AddLog("Old modem's sounds");
            Logger.AddLog("Biiiiii... Beep-beep-beep-beep... Biiiiiiiii... Biiii... Bii-beep-beep...");
            Logger.AddLog("Kshhh... Shhhh... Kshhh... Shhhh...");
            Logger.AddLog("Buuuuuuu...");
            Logger.AddLog("You are succesfully connected to the internet");


            PrintLogs();
        }
        // Dysplay all logs
        static void PrintLogs()
        {
            LogEntry[] logs = Logger.GetLogs();
            
            // Check that we have some logs
            if (logs.Length == 0)
            {
                Console.WriteLine("You should do something for adding logs");
            }
            else
            {
                foreach (LogEntry log in logs)
                {
                    Console.WriteLine($"{log.Timestamp}: {log.Message}");
                }
            }
            
        }
    }
}