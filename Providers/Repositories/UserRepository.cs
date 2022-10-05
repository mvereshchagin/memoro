using Data.Entities;
using Data.Repositories;

namespace Providers.Repositories;

public class UserRepository : DataRepository<User>, IUserRepository
{
    public UserRepository(string connectionString) : base(connectionString)
    { 
    }
    
    public User? GetByLoginAndPassword(string login, string password)
    {
        return Get
        (x =>
            x.Login == login &&
            x.Password == password
        ).SingleOrDefault();
    }
}
