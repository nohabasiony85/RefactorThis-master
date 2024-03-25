using MediatR;
using RefactorThis.Application.Products.GetProductQuery;
using Xunit;

namespace RefactorThis.Application.IntegrationTest;

public class GetProductTests(IMediator mediator)
{
    [Fact]
    public async Task GetProduct_ShouldReturnEmpty_WhenProductIdIsInvalid()
    {
        // Arrange
        var query = new GetProductQuery(new Guid("123456789"));

        // Act
        var result = await mediator.Send(query);

        // Assert
        result.Name.Equals("");
        result.Description.Equals("");
    }
}
