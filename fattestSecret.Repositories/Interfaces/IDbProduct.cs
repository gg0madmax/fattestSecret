using fattestSecret.Repositories.Entities;
using Insight.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fattestSecret.Repositories.Interfaces
{
    [Sql(Schema = "dbo")]
    public interface IDbProduct
    {
        Task<DbProduct> GetProductByIdAsync(long dbId);
        Task<List<DbProduct>> GetProductsAsync();
        Task<long> AddProductAsync(DbProduct addProduct);
        Task<DbProduct> ChangeProductAsync(DbProduct changeProduct);
    }
}