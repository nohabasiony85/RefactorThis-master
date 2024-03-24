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
           await mediator.Send(command, cancellationToken);
           return Created();
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
        public async Task<IActionResult> DeleteOption(Guid productId,Guid id, CancellationToken cancellationToken)
        {
            var command = new DeleteProductOptionCommand(id, productId);
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }

        // [HttpGet("{id}")]
        // public Product Get(int id) {
        //
        //     var guid = new Guid(BitConverter.GetBytes(id));
        //     var product = new Product(guid);
        //     if (product.IsNew)
        //         throw new Exception();
        //
        //     return product;
        // }

        // [HttpPost]
        // public IActionResult Post(Product product)
        // {
        //     if (product.IsNew) 
        //     {
        //         product.Save();
        //         return Accepted();
        //     }
        //     else {
        //         return NotFound();
        //     }
        // }

        // [HttpPut("{id}")]
        // public void Update(Guid id, Product product)
        // {
        //     var orig = new Product(id)
        //     {
        //         Name = product.Name,
        //         Description = product.Description,
        //         Price = product.Price,
        //         DeliveryPrice = product.DeliveryPrice
        //     };
        //
        //     if (!orig.IsNew)
        //         orig.Save();
        // }

        // [HttpDelete("{id}")]
        // public void Delete(Guid id) {
        //     // Ignore the seed data
        //     if (id == new Guid("3d81192d-773d-4f09-866b-ab48f9674396")) return;
        //     var product = new Product(id);
        //     product.Delete();
        // }

        // [HttpGet("{productId}/options")]
        // public ProductOptions GetOptions(Guid productId)
        // {
        //     return new ProductOptions(productId);
        // }

        // [HttpPost("{productId}/options")]
        // public void CreateOption(Guid productId, ProductOption option)
        // {
        //     option.ProductId = productId;
        //     option.Save();
        // }
        //
        // [HttpDelete("{productId}/options/{id}")]
        // public void DeleteOption(Guid productId, Guid id)
        // {
        //     var opt = new ProductOption(productId);
        //     opt.Delete();
        // }
    }
}