using Data.Entities;
using Data.Repositories;

namespace Providers.Repositories;

public class WordRepository : DataRepository<Word>, IWordRepository
{
    public WordRepository(string connectionString) : base(connectionString)
    {
    }
    
    public Word? GetByText(string text)
    {
        return Get
        (x =>
            String.Equals(x.Text, text, StringComparison.InvariantCultureIgnoreCase)
        ).SingleOrDefault();
    }

    public List<Word> GetByTranslation(string translation)
    {
        return Get
        (x =>
            String.Equals(x.Translation, translation, StringComparison.InvariantCultureIgnoreCase)
        ).ToList();
    }
}
