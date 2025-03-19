using System;
using System.IO;

public static class LocalLogger
{
  public static void Log(string message)
  {
    string logEntry = $"[{DateTime.Now:HH:mm:ss}] {message}";

    Console.WriteLine(logEntry);
  }
}
