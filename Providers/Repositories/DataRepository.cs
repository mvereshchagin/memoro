using Data.Entities;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Providers.Repositories;

public abstract class DataRepository<TEntity> : 
    IDataRepository<TEntity> where TEntity : class, IEntityItem
{
    protected readonly string _connectionString;

    protected DbContext _dbContext;
    protected DbSet<TEntity> _dbSet;

    public DataRepository(string connectionString)
    {
        _connectionString = connectionString;
        _dbContext = new DataContext(_connectionString);
        _dbSet = _dbContext.Set<TEntity>();
    }   

    public void Add(TEntity item)
    {
        _dbSet.Add(item);
        _dbContext.SaveChanges();
    }
    public void Delete(TEntity item)
    {
        _dbSet.Remove(item);
        _dbContext.SaveChanges();
    }
    public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>>? filter = null, 
        Func<IQueryable<TEntity>, 
        IOrderedQueryable<TEntity>>? orderBy = null, 
        string includeProperties = "", 
        int first = 0, 
        int offset = 0)
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter is not null)
            query = query.Where(filter);
        if (offset > 0)        
            query = query.Skip(offset);
        if (first > 0)        
            query = query.Take(first);

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
            return orderBy(query).ToList();

        return query.ToList();
    }
    
    public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null, 
        Func<IQueryable<TEntity>,
        IOrderedQueryable<TEntity>>? orderBy = null, 
        string includeProperties = "", 
        int first = 0, 
        int offset = 0)
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter is not null)
            query = query.Where(filter);
        if (offset > 0)       
            query = query.Skip(offset);
        if (first > 0)     
            query = query.Take(first);

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)       
            return await orderBy(query).ToListAsync();

        return await query.ToListAsync();

    }
    public TEntity? GetById(int id)
    {
        return Get(x => x.Id == id).SingleOrDefault();
    }
    public void Update(TEntity item)
    {   
        _dbSet.Update(item);
        _dbContext.SaveChanges();
    }
}