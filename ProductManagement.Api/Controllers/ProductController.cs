using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Products.Commands;
using ProductManagement.Application.Products.Queries;
using ProductManagement.Application.Products.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagement.Api.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<IList<ProductVm>> GetAll()
        {
            return await Mediator.Send(new GetProductsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVm>> Get(int id)
        {
            return await Mediator.Send(new GetProductByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateProductCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteProductCommand { Id = id });
        }
    }
}
