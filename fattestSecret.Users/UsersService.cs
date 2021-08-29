using fattestSecret.Repositories;
using fattestSecret.Users.Models;
using System.Threading.Tasks;

namespace fattestSecret.Users
{
    public class UsersService : IUsersService
    {
        private readonly IDbContext _dbContext;

        public UsersService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByIdAsync(long id)
        {
            var dbUser = await _dbContext.Users.GetUserByIdAsync(id);
            var user = new User
            {
                Id = dbUser.Id,
                Email = dbUser.Email,
                UserLogin = dbUser.UserLogin,
                Password = dbUser.Password,
                ConfirmPassword = dbUser.ConfirmPassword
            };
            return user;
        }
    }
}