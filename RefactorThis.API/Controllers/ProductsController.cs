//using System.Security.Cryptography;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RefactorThis.Domain.Products.CreateProductCommand;
using RefactorThis.Domain.Products.DeleteProductCommand;
using RefactorThis.Domain.Products.GetProductQuery;
using RefactorThis.Domain.Products.UpdateProductCommand;

namespace RefactorThis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
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

        [HttpGet]
        public async Task<IActionResult> Get(GetProductQuery query, CancellationToken token)
        {
            var response = await mediator.Send(query, token);
            return Ok(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command, CancellationToken token)
        {
            var response = await mediator.Send(command, token);
            return Ok(response);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommand command, CancellationToken token)
        {
            var response = await mediator.Send(command, token);
            return Ok(response);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProductCommand command, CancellationToken token)
        {
            var response = await mediator.Send(command, token);
            return Ok(response);
        }

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