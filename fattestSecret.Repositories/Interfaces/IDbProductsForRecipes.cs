using fattestSecret.Repositories.Entities;
using Insight.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fattestSecret.Repositories.Interfaces
{
    [Sql(Schema = "dbo")]
    public interface IDbProductsForRecipes
    {
        Task<List<DbProductsForRecipes>> GetRecipesByProductIdAsync(long dbId);
        Task<List<DbProductsForRecipes>> GetProductsByRecipeIdAsync(long dbId);
        Task<long> AddProductForRecipesAsync(DbProductsForRecipes addProductForRecipes);
        Task<long> AddRecipeForProductsAsync(DbProductsForRecipes addRecipeForProducts);
        Task<DbProductsForRecipes> UpdateProductForRecipesAsync(DbProductsForRecipes updateProductForRecipes);
        Task<DbProductsForRecipes> UpdateRecipeForProductsAsync(DbProductsForRecipes updateRecipeForProducts);
    }
}