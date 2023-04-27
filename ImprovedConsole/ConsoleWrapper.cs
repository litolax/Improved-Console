using System.Text.RegularExpressions;

namespace ImprovedConsole;

public static class ConsoleWrapper
{
    public static void WriteLine(string content, ConsoleColor foregroundColor = ConsoleColor.Gray,
        ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.WriteLine(content);

        Console.ResetColor();
    }

    public static void WriteLine(string content, LogType logType, bool label = false,
        ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        string tag = "";
        ConsoleColor foregroundColor = Utils.GetColorByLogType(logType);

        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        if (label) tag = Utils.GetTagByLogType(logType);

        Console.WriteLine(Regex.Replace(content, @"^(\s*)", "$1" + tag + " "));

        Console.ResetColor();
    }

    public static void Write(string content, ConsoleColor foregroundColor = ConsoleColor.Gray,
        ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.Write(content);

        Console.ResetColor();
    }

    public static void Write(string content, LogType logType, bool label = false,
        ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        string tag = "";
        ConsoleColor foregroundColor = Utils.GetColorByLogType(logType);

        if (label) tag = Utils.GetTagByLogType(logType);

        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.Write(Regex.Replace(content, @"^(\s*)", "$1" + tag + " "));

        Console.ResetColor();
    }
}