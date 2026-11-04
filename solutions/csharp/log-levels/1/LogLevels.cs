static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(": ") + 2).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int position = logLine.IndexOf(":");

        string result = logLine.Substring(0, position);

        return result.ToLower().Trim('[',']');
    }

    public static string Reformat(string logLine)
    {
        string level = logLine.Substring(
            0,
            logLine.IndexOf("]")
        ).Trim('[', ']');
        
        string message = logLine.Substring(
            logLine.IndexOf(": ") + 2
        ).Trim();
        
        string result = $"{message} ({level.ToLower()})";
        
        return result;
    }
}
