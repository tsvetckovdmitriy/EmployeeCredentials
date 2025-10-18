namespace EmployeeCredentials.Data.Interfaces;

/// <summary>
/// Определяет базовый репозиторий для работы с сущностями определённого типа.
/// </summary>
/// <typeparam name="T">Тип сущности, с которой работает репозиторий.</typeparam>
public interface IRepository<T> where T : class
{
	/// <summary>
	/// Получает все записи из базы данных.
	/// </summary>
	/// <param name="cancellationToken">Токен отмены операции.</param>
	/// <returns>Список всех сущностей типа <typeparamref name="T"/>.</returns>
	Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);

	/// <summary>
	/// Получает запись по её уникальному идентификатору.
	/// </summary>
	/// <param name="id">Уникальный идентификатор записи.</param>
	/// <param name="cancellationToken">Токен отмены операции.</param>
	/// <returns>Запись типа <typeparamref name="T"/> или null, если запись не найдена.</returns>
	Task<T?> GetByIdAsync(string id, CancellationToken cancellationToken = default);

	/// <summary>
	/// Добавляет новую запись в базу данных.
	/// </summary>
	/// <param name="entity">Запись для добавления.</param>
	/// <param name="cancellationToken">Токен отмены операции.</param>
	Task AddAsync(T entity, CancellationToken cancellationToken = default);

	/// <summary>
	/// Обновляет существующую запись в базе данных.
	/// </summary>
	/// <param name="entity">Запись с обновлёнными данными.</param>
	void Update(T entity);

	/// <summary>
	/// Удаляет запись из базы данных.
	/// </summary>
	/// <param name="entity">Запись для удаления.</param>
	void Delete(T entity);
}
