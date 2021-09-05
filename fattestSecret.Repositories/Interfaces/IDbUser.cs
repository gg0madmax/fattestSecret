using fattestSecret.Repositories.Entities;
using Insight.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fattestSecret.Repositories.Interfaces
{
    [Sql(Schema = "dbo")]
    public interface IDbUser
    {
        Task<DbUser> GetUserByIdAsync(long dbId);
        Task<List<DbUser>> GetUsersAsync();
        Task<long> AddUserAsync(DbUser addUser);
        Task<DbUser> UpdateUserAsync(DbUser updateUser);
        Task<DbUser> GetUserByEmailAsync(string email);
    }
}