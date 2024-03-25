using RefactorThis.Application.Abstractions.Data;
using RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;
using Guid = System.Guid;

namespace RefactorThis.Application.UnitTests;

public class DeleteProductOptionTests
{
    private static readonly DeleteProductOptionCommand Command = new(
        new Guid("5C2996AB-54AD-4999-92D2-89245682D534"),
        new Guid("DE1287C0-4B15-4A7B-9D8A-DD21B3CAFEC3"));

    private readonly DeleteProductOptionCommandHandler _handler;

    public DeleteProductOptionTests()
    {
        var sqlDataConnectionFactory = Substitute.For<ISqlDataConnectionFactory>();
        _handler = new DeleteProductOptionCommandHandler(sqlDataConnectionFactory);
    }

    [Fact]
    public async Task Handle_Should_ReturnSuccess_WhenProductOptionDeleted()
    {
        // Act
        var result = await _handler.Handle(Command, default);

        // Assert
        result.Equals(true);
    }

    [Fact]
    public async Task Handle_Should_ReturnFailure_WhenProductOptionIdIsNotExist()
    {
        var command = new DeleteProductOptionCommand(
            Guid.NewGuid(), new Guid("DE1287C0-4B15-4A7B-9D8A-DD21B3CAFEC3"));
        // Act
        var result = await _handler.Handle(command, default);

        // Assert
        result.Equals(false);
    }
}