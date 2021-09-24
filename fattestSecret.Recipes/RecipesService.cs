using fattestSecret.Repositories;

namespace fattestSecret.Recipes
{
    public class RecipesService : IRecipesService
    {
        private readonly IDbContext _dbContext;

        public RecipesService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}