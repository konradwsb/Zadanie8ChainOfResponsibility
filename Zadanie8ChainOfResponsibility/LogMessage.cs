public class LogMessage
{
    public string Level { get; }
    public string Message { get; }

    public LogMessage(string level, string message)
    {
        Level = level;
        Message = message;
    }
}