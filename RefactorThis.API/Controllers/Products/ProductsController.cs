//using System.Security.Cryptography;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RefactorThis.Application.CreateProductCommand;
using RefactorThis.Domain.Products.DeleteProductCommand;
using RefactorThis.Domain.Products.GetProductQuery;
using RefactorThis.Domain.Products.GetProductsByNameQuery;
using RefactorThis.Domain.Products.UpdateProductCommand;

namespace RefactorThis.Api.Controllers.Products
{
    [Route("api/[controller]")]
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
            var response = await mediator.Send(query, cancellationToken); //Should we have here response?

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var command =
                new CreateProductCommand(request.Name, request.Description, request.Price, request.DeliveryPrice);

            var response = await mediator.Send(command, cancellationToken);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(command, cancellationToken);
            return Ok(response);
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id, DeleteProductCommand command,
            CancellationToken cancellationToken)
        {
            var response = await mediator.Send(command, cancellationToken);
            return Ok(response);
        }

        // [HttpGet("test")]
        // public Products GetTest()
        // {
        //     return new Products("test");
        // }

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