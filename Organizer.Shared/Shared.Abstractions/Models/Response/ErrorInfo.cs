namespace Shared.Abstractions.Models.Response;

public sealed class ErrorInfo
{
    public string Message { get; }
    public string? StackTrace { get; }
    public ErrorInfo? InnerError { get; }

    public ErrorInfo(Exception exception)
    {
        Message = exception.Message;
        StackTrace = exception.StackTrace;
        InnerError = exception.InnerException is not null
            ? new ErrorInfo(exception.InnerException)
            : null;
    }

    public ErrorInfo(string message, string callStack)
    {
        Message = message;
        StackTrace = callStack;
    }

    public static ErrorInfo operator +(ErrorInfo error, ErrorInfo errorToMerge) =>
        new(string.Join("\n", error.Message, errorToMerge.Message),
            string.Join("\n", error.StackTrace, errorToMerge.StackTrace));

}
