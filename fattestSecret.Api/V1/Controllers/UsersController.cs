using fattestSecret.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using fattestSecret.Users.Models;

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
        [Route("get-user-by-id")]
        public async Task<IActionResult> GetUserByIdAsync(long id)
        {
            var user = await _usersService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("get-users")]
        public async Task<IActionResult> GetUsersAsync()
        {
            var users = await _usersService.GetUsersAsync();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpPost]
        [Route("add-user")]
        public async Task<IActionResult> AddUserAsync(CreationUserRequest addUser)
        {
            var user = new User
            {
                Email = addUser.Email,
                UserLogin = addUser.UserLogin,
                Password = addUser.Password
            };
            var userAwait = await _usersService.AddUserAsync(user);
            if (userAwait == null)
            {
                return NotFound();
            }
            return Ok(userAwait);
        }

        [HttpPut]
        [Route("update-user")]
        public async Task<IActionResult> UpdateUserAsync(UpdateUserRequest updateUser)
        {
            var user = new User
            {
                Id = updateUser.Id,
                Email = updateUser.Email,
                UserLogin = updateUser.UserLogin,
                Password = updateUser.Password,
                ConfirmPassword = updateUser.ConfirmPassword
            };
            await _usersService.UpdateUserAsync(user);
            return Ok();
        }
    }
}