using Insight.Database;

namespace fattestSecret.Repositories.Entities
{
    [Sql(Schema = "dbo")]
    public class DbProductsForRecipes
    {
        public long RecipesId { get; set; }
        public long ProductId { get; set; }
        public decimal Weight { get; set; }
    }
}