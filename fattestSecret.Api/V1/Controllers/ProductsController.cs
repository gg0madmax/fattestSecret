using Microsoft.AspNetCore.Mvc;
using fattestSecret.Products;
using System.Threading.Tasks;
using fattestSecret.Products.Models;

namespace fattestSecret.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver1_0)]
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

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetProductsAsync()
        {
            var products = await _productsService.GetProductsAsync();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddProductAsync(CreationProductRequest addProduct)
        {
            var product = new Product
            {
                Name = addProduct.Name,
                Kcals = addProduct.Kcals,
                Proteins = addProduct.Proteins,
                Fats = addProduct.Fats,
                Carbohydrates = addProduct.Carbohydrates
            };
            var productAwait = await _productsService.AddProductAsync(product);
            if (productAwait == null)
            {
                return NotFound();
            }
            return Ok(productAwait);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateProductAsync(UpdatingProductRequest updateProduct)
        {
            var product = new Product
            {
                Id = updateProduct.Id,
                Name = updateProduct.Name,
                Kcals = updateProduct.Kcals,
                Proteins = updateProduct.Proteins,
                Fats = updateProduct.Fats,
                Carbohydrates = updateProduct.Carbohydrates
            };
            await _productsService.UpdateProductAsync(product);
            return Ok();
        }
    }
}