namespace EmployeeCredentials.Data.Entities;

/// <summary>
/// Сотрудник.
/// </summary>
public class Employee
{
    /// <summary>
    /// Уникальный идентификатор сотрудника.
    /// </summary>
	public string Id { get; set; } = Guid.NewGuid().ToString();

	/// <summary>
	/// Имя сотрудника.
	/// </summary>
	public required string FirstName { get; set; }

	/// <summary>
	/// Фамилия сотрудника.
	/// </summary>
	public required string LastName { get; set; }

	/// <summary>
	/// Отчество сотрудника.
	/// </summary>
	public string? Patronymic { get; set; }

	/// <summary>
	/// Должность сотрудника.
	/// </summary>
	public Position Position { get; set; } = null!;
	public string PositionId { get; set; } = null!;

	/// <summary>
	/// Размер оклада сотрудника.
	/// </summary>
	public required decimal Salary { get; set; }

	/// <summary>
	/// Дата и время создания записи.
	/// </summary>
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Дата и время последнего обновления записи.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }
}
