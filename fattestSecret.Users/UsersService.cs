using fattestSecret.Repositories;
using fattestSecret.Repositories.Entities;
using fattestSecret.Users.Models;
using System;
using System.Collections.Generic;
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

        public async Task<List<User>> GetUsersAsync()
        {
            var users = new List<User>();
            var dbUsers = await _dbContext.Users.GetUsersAsync();
            foreach (var itemUser in dbUsers)
            {
                var user = new User
                {
                    Id = itemUser.Id,
                    Email = itemUser.Email,
                    UserLogin = itemUser.UserLogin,
                    Password = itemUser.Password,
                    ConfirmPassword = itemUser.ConfirmPassword
                };
                users.Add(user);
            }
            return users;
        }

        public async Task<User> AddUserAsync(User user)
        {
            var dbUserRequest = new DbUser
            {
                Email = user.Email,
                UserLogin = user.UserLogin,
                Password = user.Password
            };
            var dbGetUser = await _dbContext.Users.GetUserByEmailAsync(user.Email);
            if (dbGetUser.Email != null)
            {
                throw new Exception("Такой пользователь уже существует");
            }
            var dbUserResponse = await _dbContext.Users.AddUserAsync(dbUserRequest);
            user.Id = dbUserResponse;
            return user;
        }

        public async Task UpdateUserAsync(User user)
        {
            var dbUser = new DbUser
            {
                Id = user.Id,
                Email = user.Email,
                UserLogin = user.UserLogin,
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword,
                UpdateDate = System.DateTime.Now
            };
            await _dbContext.Users.UpdateUserAsync(dbUser);
        }
    }
}