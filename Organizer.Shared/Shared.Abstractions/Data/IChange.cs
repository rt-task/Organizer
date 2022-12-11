namespace Shared.Abstractions.Data;

public interface IChange<TRes, TModel>
    where TRes : class, new()
    where TModel : class, new()
{
    Task<TRes> CreateAsync(TModel model);
    Task<TRes> UpdateAsync(TModel model);
    Task<TRes> DeleteAsync(TModel model);
}
