using fattestSecret.Repositories.Interfaces;

namespace fattestSecret.Repositories
{
    public interface IDbContext
    {
        IDbVersion Versions { get; }
        IDbFood Food { get; }
    }
}
