using EmployeeCredentials.Data.Entities;

namespace EmployeeCredentials.Data.Interfaces;

public interface IEmployeeRepository : IRepository<Employee>
{
	Task<List<Employee>> GetByFioAsync(string fio, CancellationToken cancellationToken = default);
}
