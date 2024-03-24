using RefactorThis.Application.Abstractions.Data;
using RefactorThis.Application.Products.CreateProductCommand;

namespace RefactorThis.Application.UnitTests;

public class CreateProductTests
{
    private static readonly CreateProductCommand Command = new(
        "test product",
        "test product description",
        200, 40);
    
    private readonly CreateProductCommandHandler _handler;
    
    public CreateProductTests()
    {
        var sqlDataConnectionFactory = Substitute.For<ISqlDataConnectionFactory>();
        _handler = new CreateProductCommandHandler(sqlDataConnectionFactory);
    }
    
    [Fact]
    public async Task Handle_Should_ReturnSuccess_WhenProductCreated()
    {
        // Act
        var result = await _handler.Handle(Command, default);

        // Assert
        result.Equals(true);
    }
}