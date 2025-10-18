using EmployeeCredentials.Data.Entities;
using EmployeeCredentials.Data.Interfaces;

namespace EmployeeCredentials.Data.Repositories;

internal class PositionRepository : Repository<Position>, IPositionRepository
{
	public PositionRepository(AppDbContext context) : base(context) { }
}
