using fattestSecret.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace fattestSecret.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver1_0)]
    [Route("{version:apiVersion}/recipes")]
    [Produces("application/json")]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipesService _recipesService;

        public RecipesController(IRecipesService recipesService)
        {
            _recipesService = recipesService;
        }
    }
}