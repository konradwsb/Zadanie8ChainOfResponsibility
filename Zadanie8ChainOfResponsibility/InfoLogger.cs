public class InfoLogger : Logger
{
    private Logger nextLogger;

    public void SetNextLogger(Logger logger)
    {
        nextLogger = logger;
    }

    public void LogMessage(LogMessage logMessage)
    {
        if (logMessage.Level.Equals("INFO", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("INFO: Handling log message - " + logMessage.Message);
        }
        else if (nextLogger != null)
        {
            nextLogger.LogMessage(logMessage);
        }
    }
}