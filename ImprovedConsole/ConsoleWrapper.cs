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

    public static void WriteLine(string content, LogType logType, bool label = false, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        string labelText = "";
        
        ConsoleColor foregroundColor = logType switch
        {
            LogType.Success => ConsoleColor.DarkGreen,
            LogType.Info => ConsoleColor.DarkYellow,
            LogType.Warning => ConsoleColor.Yellow,
            LogType.Error => ConsoleColor.DarkRed,
            _ => ConsoleColor.Gray
        };

        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        if (label)
        {
            labelText = logType switch
            {
                LogType.Success => "[Success]",
                LogType.Info => "[Info]",
                LogType.Warning => "[Warning]",
                LogType.Error => "[Error]",
                _ => ""
            };
        }
        
        Console.Write(label ? labelText.Concat(" ").Concat(content) : content);

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

    public static void Write(string content, LogType logType, bool label = false, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        string labelText = "";
        
        ConsoleColor foregroundColor = logType switch
        {
            LogType.Success => ConsoleColor.DarkGreen,
            LogType.Info => ConsoleColor.DarkYellow,
            LogType.Warning => ConsoleColor.Yellow,
            LogType.Error => ConsoleColor.DarkRed,
            _ => ConsoleColor.Gray
        };

        if (label)
        {
            labelText = logType switch
            {
                LogType.Success => "[Success]",
                LogType.Info => "[Info]",
                LogType.Warning => "[Warning]",
                LogType.Error => "[Error]",
                _ => ""
            };
        }

        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;

        Console.Write(label ? labelText.Concat(" ").Concat(content) : content);

        Console.ResetColor();
    }
}