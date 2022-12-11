namespace Shared.Abstractions.Models.Relational;

public interface IOneToN<TRelation>
    where TRelation : IEntity
{
    ICollection<TRelation> RelatedEntities { get; set; }
}
