//using System.Security.Cryptography;

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

namespace RefactorThis.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        [HttpGet("{name}")]
        public async Task<IActionResult> GetAllByName(string name, CancellationToken cancellationToken)
        {
            var query = new GetProductsByNameQuery(name);

            var response = await mediator.Send(query, cancellationToken);
            return Ok(response);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetProductQuery(id);
            var response = await mediator.Send(query, cancellationToken);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var result  = await mediator.Send(command, cancellationToken);
            return result ? Created() : NotFound();
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
            var command = new DeleteProductCommand(id);
            
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
        
        [HttpGet("{productId}/options")]
        public async Task<IActionResult> GetOptions(Guid productId, CancellationToken cancellationToken)
        {
            var query = new GetProductOptionQuery(productId);
            var response = await mediator.Send(query, cancellationToken);
            return Ok(response);
        }

        [HttpPost("{productId}/options")]
        public async Task<IActionResult>  CreateOption(CreateProductOptionCommand command, CancellationToken cancellationToken)
        {
            await mediator.Send(command, cancellationToken);
            return Created();
        }

        [HttpDelete("{productId}/options/{id}")]
        public async Task<IActionResult> DeleteOption(Guid productId, Guid id, CancellationToken cancellationToken)
        {
            var command = new DeleteProductOptionCommand(id, productId);
            var result = await mediator.Send(command, cancellationToken);
            return result ? Ok() : NotFound();
        }
    }
}