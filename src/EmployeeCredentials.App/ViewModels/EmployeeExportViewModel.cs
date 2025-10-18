namespace EmployeeCredentials.App.ViewModels;

public class EmployeeExportViewModel
{
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public string? Patronymic { get; set; }
	public required string? PositionName { get; set; }
	public decimal Salary { get; set; }
	public string CreatedAt { get; set; } = null!;
	public string? UpdatedAt { get; set; }
}
