using fattestSecret.Repositories.Entities;
using Insight.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fattestSecret.Repositories.Interfaces
{
    [Sql(Schema = "dbo")]
    public interface IDbRecipes
    {
        Task<DbRecipes> GetRecipeByIdAsync(long dbId);
        Task<List<DbRecipes>> GetRecipesAsync();
        Task<long> AddRecipeAsync(DbRecipes addRecipe);
        Task<DbRecipes> UpdateRecipeAsync(DbRecipes updateRecipe);
    }
}
