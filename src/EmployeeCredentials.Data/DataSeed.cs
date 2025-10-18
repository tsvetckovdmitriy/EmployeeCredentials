using EmployeeCredentials.Data.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCredentials.Data;

public static class DataSeed
{
	public static async Task SeedAsync(this IServiceProvider serviceProvider, CancellationToken cancellationToken = default)
	{
		var context = serviceProvider.GetRequiredService<AppDbContext>();

		if (!await context.Positions.AnyAsync(cancellationToken))
		{
			var positions = new List<Position>
			{
				new() { Name = "Менеджер" },
				new() { Name = "Аналитик" },
				new() { Name = "Разработчик" },
				new() { Name = "Тестировщик" }
			};

			await context.Positions.AddRangeAsync(positions, cancellationToken);
			await context.SaveChangesAsync(cancellationToken);
		}

		if (!await context.Employees.AnyAsync(cancellationToken))
		{
			var positionsDict = await context.Positions.ToDictionaryAsync(p => p.Name, cancellationToken);

			var employees = new List<Employee>
			{
				new() {
					FirstName = "Иван",
					LastName = "Иванов",
					Patronymic = "Иванович",
					PositionId = positionsDict["Менеджер"].Id,
					Salary = 8000,
					CreatedAt = DateTime.Now.AddHours(-390).AddMinutes(-17)
				},
				new() {
					FirstName = "Мария",
					LastName = "Петрова",
					Patronymic = "Сергеевна",
					PositionId = positionsDict["Аналитик"].Id,
					Salary = 7000,
					CreatedAt = DateTime.Now.AddHours(-230).AddMinutes(-35)
				},
				new() {
					FirstName = "Алексей",
					LastName = "Сидоров",
					Patronymic = null,
					PositionId = positionsDict["Разработчик"].Id,
					Salary = 9000,
					CreatedAt = DateTime.Now.AddMinutes(-124)
				},
				new() {
					FirstName = "Ольга",
					LastName = "Кузнецова",
					Patronymic = "Владимировна",
					PositionId = positionsDict["Тестировщик"].Id,
					Salary = 6000,
					CreatedAt = DateTime.Now.AddMinutes(-357)
				},
				new() {
					FirstName = "Елена",
					LastName = "Новикова",
					Patronymic = "Александровна",
					PositionId = positionsDict["Аналитик"].Id,
					Salary = 7200,
					CreatedAt = DateTime.Now.AddMinutes(-12)
				},
				new() {
					FirstName = "Дмитрий",
					LastName = "Фёдоров",
					Patronymic = "Сергеевич",
					PositionId = positionsDict["Разработчик"].Id,
					Salary = 9500,
					CreatedAt = DateTime.Now.AddMinutes(-5)
				},
				new() {
					FirstName = "Наталья",
					LastName = "Смирнова",
					Patronymic = "Игоревна",
					PositionId = positionsDict["Менеджер"].Id,
					Salary = 8200,
					CreatedAt = DateTime.Now
				},
				new() {
					FirstName = "Сергей",
					LastName = "Ковалев",
					Patronymic = null,
					PositionId = positionsDict["Разработчик"].Id,
					Salary = 8800,
					CreatedAt = DateTime.Now
				},
				new() {
					FirstName = "Анастасия",
					LastName = "Васильева",
					Patronymic = "Петровна",
					PositionId = positionsDict["Тестировщик"].Id,
					Salary = 6100,
					CreatedAt = DateTime.Now
				},
				new() {
					FirstName = "Владимир",
					LastName = "Попов",
					Patronymic = "Алексеевич",
					PositionId = positionsDict["Менеджер"].Id,
					Salary = 8300,
					CreatedAt = DateTime.Now
				},
				new() {
					FirstName = "Ирина",
					LastName = "Гордеева",
					Patronymic = "Сергеевна",
					PositionId = positionsDict["Аналитик"].Id,
					Salary = 7100,
					CreatedAt = DateTime.Now
				}
			};

			await context.Employees.AddRangeAsync(employees, cancellationToken);
			await context.SaveChangesAsync(cancellationToken);
		}
	}
}
