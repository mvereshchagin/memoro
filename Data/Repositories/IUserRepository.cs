using Data.Entities;

namespace Data.Repositories;

public interface IUserRepository : IDataRepository<User>
{
    User? GetByLoginAndPassword(string login, string password);
}
