﻿using fattestSecret.Repositories.Entities;
using Insight.Database;
using System.Threading.Tasks;

namespace fattestSecret.Repositories.Interfaces
{
    [Sql(Schema = "dbo")]
    public interface IDbFood
    {
        Task<DbFood> GetFoodByIdAsync(int dbId);
    }
}
