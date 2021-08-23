using fattestSecret.Food.Models;
using System.Threading.Tasks;

namespace fattestSecret.Food
{
    public interface IFoodService
    {
        Task<Product> GetFoodById(int id);
    }
}
