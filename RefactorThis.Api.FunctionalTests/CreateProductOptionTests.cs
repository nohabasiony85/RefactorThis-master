using System.Net;
using Xunit;

namespace RefactorThis.Api.FunctionalTests;

public class CreateProductOptionTests
{
    private static Guid _newGuid;

    public CreateProductOptionTests()
    {
        _newGuid = Guid.NewGuid();
    }

    // [Theory]
    // [InlineData(_newGuid, "name 1", "description 1")]
    // public async Task Register_ShouldReturnBadRequest_WhenRequestIsInvalid(
    //     Guid productId, string name, string description)
    // {
    //     // Arrange
    //     var request = new (productId, name, description);
    //
    //     // Act
    //     HttpResponseMessage response = await HttpClient.PostAsJsonAsync("/products/{id}/options", request);
    //
    //     // Assert
    //     response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    // }

    // [Fact]
    // public async Task Register_ShouldReturnOk_WhenRequestIsValid()
    // {
    //     // Arrange
    //     var request = new RegisterUserRequest("create@test.com", "first", "last", "12345");
    //
    //     // Act
    //     HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/users/register", request);
    //
    //     // Assert
    //     response.StatusCode.Should().Be(HttpStatusCode.OK);
    // }
}