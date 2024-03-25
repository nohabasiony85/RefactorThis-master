using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Entities;

public class ProductOption : Entity
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}