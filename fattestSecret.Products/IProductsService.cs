using fattestSecret.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fattestSecret.Products
{
    public interface IProductsService
    {
        Task<Product> GetProductByIdAsync(long id);
        Task<List<Product>> GetProductsAsync();
        Task<Product> AddProductAsync(Product product);
        Task ChangeProductAsync(Product product);
    }
}