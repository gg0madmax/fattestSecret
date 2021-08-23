using Microsoft.AspNetCore.Mvc;
using fattestSecret.Food;
using System.Threading.Tasks;

namespace fattestSecret.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver1_0)]
    [Route("{version:apiVersion}/Food")]
    [Produces("application/json")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        [Route("GetFoodById")]
        public async Task<IActionResult> GetFoodById(int id)
        {
            var food = await _foodService.GetFoodById(id);
            if (food == null)
            {
                return NotFound();
            }
            return Ok(food);
        }
    }
}