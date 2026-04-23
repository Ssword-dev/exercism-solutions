static class LogLine
{
    public static string Message(string logLine)
    {
        var indexOfColon = logLine.IndexOf(':');
        return logLine.Substring(indexOfColon + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        var indexOfOpenBracket = logLine.IndexOf('[');
        var indexOfCloseBracket = logLine.IndexOf(']');
        return logLine.Substring(indexOfOpenBracket + 1, indexOfCloseBracket - 1).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        var message = Message(logLine);
        var level = LogLevel(logLine);
        return $"{message} ({level})";
    }
}
