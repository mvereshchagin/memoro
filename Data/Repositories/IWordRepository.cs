using Data.Entities;
namespace Data.Repositories;

public interface IWordRepository : IDataRepository<Word>
{
    Word? GetByText(string text);

    List<Word> GetByTranslation(string translation);
}

