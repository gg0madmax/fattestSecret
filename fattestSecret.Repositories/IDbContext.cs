using fattestSecret.Repositories.Interfaces;

namespace fattestSecret.Repositories
{
    public interface IDbContext
    {
        IDbVersion Versions { get; }
        IDbProduct Products { get; }
        IDbUser Users { get; }
    }
}
