using fattestSecret.Users.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fattestSecret.Users
{
    public interface IUsersService
    {
        Task<User> GetUserByIdAsync(long id);
        Task<List<User>> GetUsersAsync();
        Task<User> AddUserAsync(User user);
        Task UpdateUserAsync(User user);
    };
}