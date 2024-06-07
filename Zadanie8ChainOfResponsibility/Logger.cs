public interface Logger
{
    void SetNextLogger(Logger logger);
    void LogMessage(LogMessage logMessage);
}