using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

public class Program
{
    private const string LogFilePath = "log.txt";
    private const int MaxLifetimeMinutes = 5;
    private const int RefreshIntervalMilliseconds = 120000; // 2 minutes

    public static void Main(string[] args)
    {
        Console.WriteLine("Open Applications:");
        Console.WriteLine("---------------------");

        while (true)
        {
            DisplayOpenApplications();
            CheckAndTerminateProcesses();
            DisplayExitMessage();

            if (ShouldExit())
                break;

            System.Threading.Thread.Sleep(RefreshIntervalMilliseconds);
        }
    }

    private static void DisplayOpenApplications()
    {
        Console.Clear();
        Console.WriteLine("Open Applications:");
        Console.WriteLine("---------------------");

        Process[] processes = GetProcessesWithNonEmptyWindowTitles();
        foreach (var process in processes)
        {
            TimeSpan lifetime = DateTime.Now - process.StartTime;
            Console.WriteLine($"Application Name: {process.ProcessName}, Window Title: {process.MainWindowTitle}, Lifetime: {GetLifetimeString(lifetime)}");
        }
    }

    private static Process[] GetProcessesWithNonEmptyWindowTitles()
    {
        return Process.GetProcesses()
                      .Where(p => !string.IsNullOrEmpty(p.MainWindowTitle))
                      .ToArray();
    }

    private static string GetLifetimeString(TimeSpan lifetime)
    {
        return $"{lifetime.TotalMinutes:F0} minutes, {lifetime.Seconds} seconds";
    }

    private static void CheckAndTerminateProcesses()
    {
        Process[] processes = GetProcessesWithNonEmptyWindowTitles();
        foreach (var process in processes)
        {
            TimeSpan lifetime = DateTime.Now - process.StartTime;
            if (lifetime.TotalMinutes > MaxLifetimeMinutes)
            {
                process.Kill();
                LogToFile($"Process {process.ProcessName} terminated due to exceeded lifetime.");
            }
        }
    }

    private static void DisplayExitMessage()
    {
        Console.WriteLine("\nPress 'q' to exit.");
    }

    private static bool ShouldExit()
    {
        return Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q;
    }

    private static void LogToFile(string message)
    {
        using (StreamWriter writer = new StreamWriter(LogFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    internal static void LogToFile(string logFilePath, string message)
    {
        throw new NotImplementedException();
    }
}

