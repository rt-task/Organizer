namespace Shared.Abstractions.Models.Relational;

public interface INToOne<TRelation, TKey>
    where TRelation : IEntity<TKey>
    where TKey : struct, IEquatable<TKey>
{
    TRelation RelatedEntity { get; set; }
    TKey RelatedEntityKey { get; set; }
}
