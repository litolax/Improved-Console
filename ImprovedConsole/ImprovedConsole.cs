namespace ImprovedConsole;

public static class ImprovedConsole
{
    public static void WriteLine(string content, ConsoleColor foregroundColor = ConsoleColor.Gray,
        ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.WriteLine(content);

        Console.ResetColor();
    }

    public static void WriteLine(string content, LogType logType, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        ConsoleColor foregroundColor = logType switch
        {
            LogType.Warning => ConsoleColor.Yellow,
            LogType.Error => ConsoleColor.DarkRed,
            _ => ConsoleColor.Gray
        };

        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.WriteLine(content);

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

    public static void Write(string content, LogType logType, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        ConsoleColor foregroundColor = logType switch
        {
            LogType.Warning => ConsoleColor.Yellow,
            LogType.Error => ConsoleColor.DarkRed,
            _ => ConsoleColor.Gray
        };

        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.Write(content);

        Console.ResetColor();
    }
}