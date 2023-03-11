using Application.Products;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ProductsController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts(CancellationToken cancellationToken)
    {
        return await Mediator.Send(new List.Query(), cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(string id)
    {
        return await Mediator.Send(new Details.Query { Id = id });
    }

    [HttpPost]
    public async Task<ActionResult<Unit>> CreateProduct(Product product)
    {
        return Ok(await Mediator.Send(new Create.Command { Product = product }));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Unit>> EditProduct(string id, Product product)
    {
        product.Id = id;
        return Ok(await Mediator.Send(new Edit.Command { Product = product }));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> DeleteProduct(Guid id)
    {
        return Ok(await Mediator.Send(new Delete.Command { Id = id }));
    }
}