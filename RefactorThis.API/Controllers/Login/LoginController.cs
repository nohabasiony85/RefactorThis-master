using MediatR;
using Microsoft.AspNetCore.Mvc;
using RefactorThis.Application.Login.LoginQuery;

namespace RefactorThis.Api.Controllers.Login;

[Route("api/[controller]")]
[ApiController]
public class LoginController(IMediator mediator) : ControllerBase
{
    [HttpGet("{username}/{password}")]
    public async Task<IActionResult> Login(LoginRequest request, CancellationToken cancellationToken)
    {
        var query = new LoginQuery(request.UserName, request.Password);

        var response = await mediator.Send(query, cancellationToken);

        return response.LoggedIn ? Ok(response.Message) : BadRequest(response.Message);
    }
}