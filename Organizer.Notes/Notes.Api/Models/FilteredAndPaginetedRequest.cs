using Shared.Abstractions.Models.Api;

namespace Notes.Api.Models
{
    public class FilteredAndPaginetedRequest : IFiltered, IPaginated
    {
        public Dictionary<string, string>? Filters { get; init; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
