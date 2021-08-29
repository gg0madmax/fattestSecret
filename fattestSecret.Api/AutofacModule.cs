using Autofac;
using fattestSecret.Food;
using fattestSecret.Repositories;
using fattestSecret.Users;
using Microsoft.Extensions.Configuration;
using System;

namespace fattestSecret.Api
{
    public class AutofacModule : Module
    {
        private readonly IConfiguration _configuration;

        public AutofacModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new DbConnectionSettings
            {
                ConnectionString = _configuration["Database:ConnectionString"],
                CommandTimeout = Convert.ToInt32(_configuration["Database:CommandTimeout"])
            }).As<DbConnectionSettings>().SingleInstance();
            builder.RegisterType<DbContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<FoodService>().As<IFoodService>().InstancePerLifetimeScope();
            builder.RegisterType<UsersService>().As<IUsersService>().InstancePerLifetimeScope();
        }
    }
}