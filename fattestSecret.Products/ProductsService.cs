using System.Threading.Tasks;
using fattestSecret.Repositories;
using fattestSecret.Products.Models;
using System.Collections.Generic;
using fattestSecret.Repositories.Entities;

namespace fattestSecret.Products
{
    public class ProductsService : IProductsService
    {
        private readonly IDbContext _dbContext;

        public ProductsService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Product> GetProductByIdAsync(long id)
        {
            var dbProduct = await _dbContext.Products.GetProductByIdAsync(id);
            var product = new Product
            {
                Id = dbProduct.Id,
                Name = dbProduct.Name,
                Kcals = dbProduct.Kcals,
                Proteins = dbProduct.Proteins,
                Fats = dbProduct.Fats,
                Carbohydrates = dbProduct.Carbohydrates
            };
            return product;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products = new List<Product>();
            var dbProducts = await _dbContext.Products.GetProductsAsync();
            foreach (var itemProduct in dbProducts)
            {
                var product = new Product
                {
                    Id = itemProduct.Id,
                    Name = itemProduct.Name,
                    Kcals = itemProduct.Kcals,
                    Proteins = itemProduct.Proteins,
                    Fats = itemProduct.Fats,
                    Carbohydrates = itemProduct.Carbohydrates
                };
                products.Add(product);
            }
            return products;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            var dbProductRequest = new DbProduct
            {
                Name = product.Name,
                Kcals = product.Kcals,
                Proteins = product.Proteins,
                Fats = product.Fats,
                Carbohydrates = product.Carbohydrates
            };
            var dbProductResponse = await _dbContext.Products.AddProductAsync(dbProductRequest);
            product.Id = dbProductResponse;
            return product;
        }

        public async Task ChangeProductAsync(Product product)
        {
            var dbProductRequest = new DbProduct
            {
                Id = product.Id,
                Name = product.Name,
                Kcals = product.Kcals,
                Proteins = product.Proteins,
                Fats = product.Fats,
                Carbohydrates = product.Carbohydrates,
                UpdateDate = System.DateTime.Now
            };
            await _dbContext.Products.ChangeProductAsync(dbProductRequest);
        }
    }
}