using Data.Entities;
using System.Linq.Expressions;
namespace Data.Repositories;

public interface IDataRepository<TEntity> where TEntity : class, IEntityItem
{
    void Add(TEntity item);
    void Delete(TEntity item);
    void Update(TEntity item);

    IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "", 
        int first = 0, int offset = 0);

    Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "",
        int first = 0, int offset = 0);

    TEntity? GetById(int id);
}
