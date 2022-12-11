using Shared.Abstractions.Models.Response;

namespace Shared.Abstractions.Models.Api;

public class PaginatedResponse<TList, TContent> : ResultInfo<TList>
    where TList : ICollection<TContent>
{
    public int Count { get; set; }

    public PaginatedResponse(TList content, int count, Outcome outcome = Outcome.OK) : 
        base(outcome, content)
    {
        Count = count;
    }

    public PaginatedResponse(Outcome outcome = Outcome.KO, params ErrorInfo[] errors) :
        base(outcome, errors)
    {
    }

    public PaginatedResponse(Outcome outcome, TList content, int count, params ErrorInfo[] errors) :
        base(outcome, content, errors)
    {
        Count = count;
    }
}
