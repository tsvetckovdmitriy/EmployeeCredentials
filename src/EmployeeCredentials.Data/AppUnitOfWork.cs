using EmployeeCredentials.Data.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCredentials.Data;

internal class AppUnitOfWork : IAppUnitOfWork
{
	private readonly AppDbContext _context;
	private readonly IServiceProvider _serviceProvider;
	private bool _disposed = false;

	public AppUnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
	{
		_context = context;
		_serviceProvider = serviceProvider;
	}

	public IEmployeeRepository EmployeeRepository => _serviceProvider.GetRequiredService<IEmployeeRepository>();
	public IPositionRepository PositionRepository => _serviceProvider.GetRequiredService<IPositionRepository>();

	public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		=> await _context.SaveChangesAsync(cancellationToken);

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (disposing)
			{
				_context.Dispose();
			}
		}
		_disposed = true;
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
}
