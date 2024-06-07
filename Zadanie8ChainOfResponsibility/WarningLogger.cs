public class WarningLogger : Logger
{
    private Logger nextLogger;

    public void SetNextLogger(Logger logger)
    {
        nextLogger = logger;
    }

    public void LogMessage(LogMessage logMessage)
    {
        if (logMessage.Level.Equals("WARNING", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("WARNING: Handling log message - " + logMessage.Message);
        }
        else if (nextLogger != null)
        {
            nextLogger.LogMessage(logMessage);
        }
    }
}