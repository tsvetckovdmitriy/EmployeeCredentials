using EmployeeCredentials.Data.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace EmployeeCredentials.Data.Repositories;

internal class Repository<T> : IRepository<T> where T : class
{
	protected readonly AppDbContext _context;
	protected readonly DbSet<T> _dbSet;

	public Repository(AppDbContext context)
	{
		_context = context;
		_dbSet = _context.Set<T>();
	}

	public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
		=> await _dbSet.ToListAsync(cancellationToken);

	public virtual async Task<T?> GetByIdAsync(string id, CancellationToken cancellationToken = default)
		=> await _dbSet.FindAsync(id, cancellationToken);

	public virtual async Task AddAsync(T entity, CancellationToken cancellationToken = default)
		=> await _dbSet.AddAsync(entity, cancellationToken);

	public virtual void Update(T entity)
		=> _dbSet.Update(entity);

	public virtual void Delete(T entity)
		=> _dbSet.Remove(entity);
}
