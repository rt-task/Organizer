using Shared.Abstractions.Models.Api;

namespace Shared.Abstractions.Data
{
    public interface IRead<TRes, in TKey, in TParams>
        where TRes : class, new()
        where TKey : struct, IEquatable<TKey>
        where TParams : IPaginated, IFiltered
    {
        Task<TRes> ReadAsync(TKey key);
        Task<IEnumerable<TRes>> ReadAsync(TParams filters);
    }
}