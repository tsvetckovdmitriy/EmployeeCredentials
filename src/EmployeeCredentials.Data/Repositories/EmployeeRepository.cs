using EmployeeCredentials.Data.Entities;
using EmployeeCredentials.Data.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace EmployeeCredentials.Data.Repositories;

internal class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
	public EmployeeRepository(AppDbContext context) : base(context) { }

	public override async Task<List<Employee>> GetAllAsync(CancellationToken cancellationToken = default)
		=> await _dbSet.Include(x => x.Position).ToListAsync(cancellationToken);

	public async Task<List<Employee>> GetByFioAsync(string fio, CancellationToken cancellationToken = default)
		=> await _dbSet.Include(x => x.Position)
		.Where(x => EF.Functions.Like((x.LastName ?? "").ToLower() + " " +
							  (x.FirstName ?? "").ToLower() + " " +
							  (x.Patronymic ?? "").ToLower(), $"%{fio}%"))
		.ToListAsync(cancellationToken);
}
