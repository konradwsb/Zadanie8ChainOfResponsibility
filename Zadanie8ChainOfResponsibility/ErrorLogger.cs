public class ErrorLogger : Logger
{
    private Logger nextLogger;

    public void SetNextLogger(Logger logger)
    {
        nextLogger = logger;
    }

    public void LogMessage(LogMessage logMessage)
    {
        if (logMessage.Level.Equals("ERROR", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("ERROR: Handling log message - " + logMessage.Message);
        }
        else if (nextLogger != null)
        {
            nextLogger.LogMessage(logMessage);
        }
    }
}