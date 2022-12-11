using Microsoft.EntityFrameworkCore;
using Shared.Abstractions.Models.Api;
using Shared.Abstractions.Models.Relational;
using System.Linq.Dynamic.Core;

namespace Shared.Helpers;

public static class LinqToEntitiesExtension
{
    public static IQueryable<TEntity> Filter<TEntity, TFilter>(this IQueryable<TEntity> source,
        TFilter filters)
        where TEntity : IEntity
        where TFilter : IFiltered
    {
        if (filters?.Filters == null)
            return source;

        var entityProperties = typeof(TEntity).GetProperties().Select(p => p.Name);

        foreach (var filter in filters.Filters)
        {
            if (entityProperties.Contains(filter.Key))
            {
                var filterExpr = $"{filter.Key}.Contains(@0)";
                source = source.Where(filterExpr, filter.Value);
            }
        }

        return source;
    }

    public static Tuple<IQueryable<TEntity>, Task<int>> PaginateAndCount<TEntity, TPagination>(
        this IQueryable<TEntity> source, TPagination pagination)
        where TEntity : IEntity
        where TPagination : IPaginated
        => Tuple.Create(
            source.Skip(pagination.PageIndex - 1 * pagination.PageSize).Take(pagination.PageSize),
            source.CountAsync());
}
