using MediatR;
using Microsoft.AspNetCore.Mvc;
using RefactorThis.Application.ProductOptions.CreateProductOptionCommand;
using RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;
using RefactorThis.Application.ProductOptions.GetProductOptionQuery;
using RefactorThis.Application.Products.CreateProductCommand;
using RefactorThis.Application.Products.DeleteProductCommand;
using RefactorThis.Application.Products.GetProductQuery;
using RefactorThis.Application.Products.GetProductsByNameQuery;
using RefactorThis.Application.Products.UpdateProductCommand;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;

namespace RefactorThis.Api.Controllers;

[Route("api/products")]
[ApiController]
public class ProductsController(IMediator mediator) : ControllerBase
{
    [HttpGet("{name}")]
    public async Task<IActionResult> GetAllByName(string name, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new GetProductsByNameQuery(name), cancellationToken);
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new GetProductQuery(id), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return result ? Created() : BadRequest();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
        return NoContent();
    }


    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        await mediator.Send(new DeleteProductCommand(id), cancellationToken);
        return NoContent();
    }

    [HttpGet("{productId}/options")]
    public async Task<IActionResult> GetOptions(Guid productId, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new GetProductOptionQuery(productId), cancellationToken);
        return Ok(response);
    }

    [HttpPost("{productId}/options")]
    public async Task<IActionResult> CreateOption(CreateProductOptionCommand command,
        CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
        return Created();
    }

    [HttpDelete("{productId}/options/{id}")]
    public async Task<IActionResult> DeleteOption(Guid productId, Guid id, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new DeleteProductOptionCommand(id, productId), cancellationToken);
        return result ? Ok() : NotFound();
    }
}