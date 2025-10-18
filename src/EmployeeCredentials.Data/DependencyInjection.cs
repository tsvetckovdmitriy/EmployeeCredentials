using EmployeeCredentials.Data.Interfaces;
using EmployeeCredentials.Data.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCredentials.Data;

public static class DependencyInjection
{
	public static void AddServicesData(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<AppDbContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

		services.AddScoped<IEmployeeRepository, EmployeeRepository>();
		services.AddScoped<IPositionRepository, PositionRepository>();

		services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
	}

	public static async Task ApplyMigrationsAsync(this IServiceProvider serviceProvider, CancellationToken cancellationToken = default)
	{
		using var scope = serviceProvider.CreateScope();
		var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
		await dbContext.Database.MigrateAsync(cancellationToken);
	}
}
