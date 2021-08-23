using System.Threading.Tasks;
using fattestSecret.Repositories;
using fattestSecret.Food.Models;

namespace fattestSecret.Food
{
    public class FoodService : IFoodService
    {
        private readonly IDbContext _dbContext;

        public FoodService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Product> GetFoodById(int id)
        {
            var dbFood = await _dbContext.Food.GetFoodByIdAsync(id);
            var food = new Product
            {
                Id = dbFood.Id,
                Name = dbFood.Name,
                Kcals = dbFood.Kcals,
                Proteins = dbFood.Proteins,
                Fats = dbFood.Fats,
                Carbohydrates = dbFood.Carbohydrates,
                CreateDate = dbFood.CreateDate,
                UpdateDate = dbFood.UpdateDate
            };
            return food;
        }
    }
}
