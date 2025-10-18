namespace EmployeeCredentials.Data.Entities;

/// <summary>
/// Должность.
/// </summary>
public class Position
{
	/// <summary>
	/// Уникальный идентификатор сотрудника.
	/// </summary>
	public string Id { get; set; } = Guid.NewGuid().ToString();

	/// <summary>
	/// Наименование должности.
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Дата и время создания записи.
	/// </summary>
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Дата и время последнего обновления записи.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }
}
