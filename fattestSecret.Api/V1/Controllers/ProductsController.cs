using Microsoft.AspNetCore.Mvc;
using fattestSecret.Products;
using System.Threading.Tasks;
using fattestSecret.Products.Models;

namespace fattestSecret.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver1_0)]
    [Route("{version:apiVersion}/Products")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [Route("GetProductById")]
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
        [Route("GetProducts")]
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
        [Route("AddProduct")]
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

        [HttpPost]
        [Route("ChangeProduct")]
        public async Task<IActionResult> ChangeProductAsync(ChangeProductRequest changeProduct)
        {
            var product = new Product
            {
                Id = changeProduct.Id,
                Name = changeProduct.Name,
                Kcals = changeProduct.Kcals,
                Proteins = changeProduct.Proteins,
                Fats = changeProduct.Fats,
                Carbohydrates = changeProduct.Carbohydrates
            };
            await _productsService.ChangeProductAsync(product);
            return Ok();
        }
    }
}