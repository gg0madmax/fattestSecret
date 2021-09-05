using Microsoft.AspNetCore.Mvc;
using fattestSecret.Products;
using System.Threading.Tasks;

namespace fattestSecret.Api.V2.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver2_0)]
    [Route("{version:apiVersion}/products")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProductByIdAsync(long id)
        {
            var product = await _productsService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}