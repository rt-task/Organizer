namespace Shared.Abstractions.Models.Response;

public class ResultInfo<TContent>
{
    public Outcome Outcome { get; }
    public TContent? Content { get; }
    public ICollection<ErrorInfo>? Errors { get; }

    public ResultInfo(TContent content, Outcome outcome = Outcome.OK)
    {
        Outcome = outcome;
        Content = content;
    }

    public ResultInfo(Outcome outcome = Outcome.KO, params ErrorInfo[] errors)
    {
        Outcome = outcome;
        Errors = errors;
    }

    public ResultInfo(Outcome outcome, TContent content, params ErrorInfo[] errors)
    {
        Outcome = outcome;
        Content = content;
        Errors = errors;
    }
}

public enum Outcome
{
    KO,
    OK
}