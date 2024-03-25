using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.UnitTests;

public class ProductData
{
    public static Product Create()
    {
        return new Product(
            Guid.NewGuid(),
            "Product1 Name ",
            "Product1 Description",
            100,
            20
        );
    }
}