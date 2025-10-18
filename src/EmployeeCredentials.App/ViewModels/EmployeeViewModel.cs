namespace EmployeeCredentials.App.ViewModels;

public class EmployeeViewModel
{
	public string Id { get; set; } = null!;
	public string FullName { get; set; } = null!;
	public string? PositionName { get; set; }
	public decimal Salary { get; set; }
	public string CreatedAt { get; set; } = null!;
	public string? UpdatedAt { get; set; }
}
