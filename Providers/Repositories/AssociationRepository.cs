using Data.Entities;
using Data.Repositories;

namespace Providers.Repositories;

public class AssociationRepository : DataRepository<Association>, IAssociationRepository
{
    public AssociationRepository(string connectionString) : base(connectionString)
    {
    }
    
    public Association? GetByText(string text)
    {
        return Get
            (x =>
                String.Equals(x.Text, text, StringComparison.InvariantCultureIgnoreCase)
            ).SingleOrDefault();
    }
}
