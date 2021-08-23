using fattestSecret.Repositories.Interfaces;
using Insight.Database;
using System;
using System.Data.Common;

namespace fattestSecret.Repositories
{
    public class DbContext : IDbContext
    {
        private readonly System.Data.IDbConnection _connection;

        public DbContext(DbConnectionSettings connectionStringSettings)
        {
            var providerFactory = DbProviderFactories.GetFactory(DbConnectionSettings.ProviderName);
            _connection = providerFactory.CreateConnection() ?? throw new Exception("Connection object is null");
            _connection.ConnectionString = connectionStringSettings.ConnectionString;
        }

        public IDbVersion Versions => CreateRepository<IDbVersion>();
        public IDbFood Food => CreateRepository<IDbFood>();

        public TRepository CreateRepository<TRepository>() where TRepository : class
        {
            return _connection.As<TRepository>();
        }
    }
}
