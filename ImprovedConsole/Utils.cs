namespace ImprovedConsole;

public static class Utils
{
    public static ConsoleColor GetColorByLogType(LogType logType)
    {
        return logType switch
        {
            LogType.Success => ConsoleColor.DarkGreen,
            LogType.Info => ConsoleColor.DarkYellow,
            LogType.Warning => ConsoleColor.Yellow,
            LogType.Error => ConsoleColor.DarkRed,
            _ => ConsoleColor.Gray
        };
    }
    
    public static string GetTagByLogType(LogType logType)
    {
        return logType switch
        {
            LogType.Success => "[Success]",
            LogType.Info => "[Info]",
            LogType.Warning => "[Warning]",
            LogType.Error => "[Error]",
            _ => ""
        };
    }
}