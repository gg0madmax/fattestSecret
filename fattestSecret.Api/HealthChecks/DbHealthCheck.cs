using fattestSecret.Repositories;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace fattestSecret.Api.HealthChecks
{
    public class DbHealthCheck : IHealthCheck
    {
        private readonly IDbContext _dbContext;

        public DbHealthCheck(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellation = new CancellationToken())
        {
            try
            {
                var ver = await _dbContext.Versions.GetVersionAsync();
                return HealthCheckResult.Healthy($"Database available. Version: {ver.Version}");
            }
            catch (Exception e)
            {
                return HealthCheckResult.Unhealthy($"Database not available: {e.Message}");
            }
        }
    }
}
