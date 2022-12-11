namespace Shared.Abstractions.Models.Api;

public interface IFiltered
{
    Dictionary<string, string>? Filters { get; init; }
}
