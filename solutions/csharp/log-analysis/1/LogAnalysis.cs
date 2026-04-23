public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string after) {
        return str.Substring(str.IndexOf(after) + after.Length);
    }

    public static string SubstringBetween(this string  str, string before, string after) {
        int start = str.IndexOf(before) + before.Length;
        int end = str.IndexOf(after);
        return str.Substring(start, end - start);
    }

    public static string Message(this string logLine) {
        return SubstringAfter(logLine, ":").Trim();
    }

    public static string LogLevel(this string logLine) {
        return SubstringBetween(logLine, "[", "]").Trim();
    }
}