using Microsoft.Extensions.Logging;

namespace Shared.Helpers;

public static class LogHelper
{
    public static void StandardLog(this ILogger logger, LogLevel level, Exception exception) =>
        logger.Log(level, "Message: {Message}\n StackTrace: {StackTrace}\n Inner: {InnerException}",
            exception.Message, exception.StackTrace, exception.InnerException);

    public static void StandardLog(this ILogger logger, LogLevel level, string message, string stackTrace, Exception innerException) =>
        logger.Log(level, "Message: {Message}\n StackTrace: {StackTrace}\n Inner: {InnerException}",
            message, stackTrace, innerException);
}
