using fattestSecret.Repositories.Interfaces;

namespace fattestSecret.Repositories
{
    public interface IDbContext
    {
        IDbVersion Versions { get; }
        IDbProduct Products { get; }
        IDbUser Users { get; }
        IDbRecipes Recipes { get; }
        IDbProductsForRecipes ProductsForRecipes { get; }
    }
}