using EmployeeCredentials.Data.Entities;

using Microsoft.EntityFrameworkCore;

namespace EmployeeCredentials.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<Employee> Employees { get; set; }
	public DbSet<Position> Positions { get; set; }
}
