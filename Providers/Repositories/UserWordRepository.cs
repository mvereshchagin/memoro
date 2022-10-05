using Data.Entities;
using Data.Repositories;

namespace Providers.Repositories;

public class UserWordRepository : DataRepository<UserWord>, IUserWordRepository
{
    public UserWordRepository(string connectionString) : base(connectionString)
    { 
    }

    public List<UserWord> GetByStatus(WordStatus status)
    {
        return Get
        (x =>
            x.Status == status
        ).ToList();
    }
}
