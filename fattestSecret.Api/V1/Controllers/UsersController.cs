using fattestSecret.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace fattestSecret.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver1_0)]
    [Route("{version:apiVersion}/users")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<IActionResult> GetUserByIdAsync(long id)
        {
            var user = await _usersService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
