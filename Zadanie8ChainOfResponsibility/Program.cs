
public class Program
{
    public static void Main(string[] args)
    {
        Logger infoLogger = new InfoLogger();
        Logger warningLogger = new WarningLogger();
        Logger errorLogger = new ErrorLogger();

        infoLogger.SetNextLogger(warningLogger);
        warningLogger.SetNextLogger(errorLogger);

        while (true)
        {
            Console.WriteLine("Select message level (INFO/WARNING/ERROR/End):");
            string level = Console.ReadLine().Trim();

            if (level.Equals("End", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.WriteLine("Enter message content:");
            string message = Console.ReadLine().Trim();

            LogMessage logMessage = new LogMessage(level, message);
            infoLogger.LogMessage(logMessage);
        }
    }
}


