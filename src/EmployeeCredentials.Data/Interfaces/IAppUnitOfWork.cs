namespace EmployeeCredentials.Data.Interfaces;

/// <summary>
/// Представляет единицу работы (Unit of Work) для доступа к репозиториям сотрудников и должностей
/// с возможностью сохранения изменений в базе данных.
/// </summary>
public interface IAppUnitOfWork : IDisposable
{
	/// <summary>
	/// Репозиторий для работы с сущностями сотрудников.
	/// </summary>
	IEmployeeRepository EmployeeRepository { get; }

	/// <summary>
	/// Репозиторий для работы с сущностями должностей.
	/// </summary>
	IPositionRepository PositionRepository { get; }

	/// <summary>
	/// Сохраняет все изменения, выполненные через репозитории, в базе данных.
	/// </summary>
	/// <param name="cancellationToken">Токен отмены операции.</param>
	/// <returns>Количество сохранённых записей в базе данных.</returns>
	Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
