using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Entities;

public class Product : Entity
{
    public Product(
        Guid id,
        string name,
        string description,
        decimal price,
        decimal deliveryPrice)
        : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        DeliveryPrice = deliveryPrice;
    }

    public Product()
    {
    }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public decimal DeliveryPrice { get; set; }
}