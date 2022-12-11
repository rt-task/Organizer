namespace Shared.Abstractions.Models.Api;

public interface IPaginated
{
    int PageIndex { get; set; }
    int PageSize { get; set; }
}
