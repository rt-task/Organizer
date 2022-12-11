namespace Shared.Abstractions.Models.Relational;

public interface IEntity { }

public interface IEntity<TKey> : IEntity
    where TKey : struct, IEquatable<TKey>
{
    TKey Id { get; set; }
}
