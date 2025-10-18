using System.Diagnostics;

using ClosedXML.Excel;

using EmployeeCredentials.App.ViewModels;
using EmployeeCredentials.Data.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCredentialsApp;

public partial class FormMain : Form
{
	private readonly IServiceProvider _serviceProvider;
	private readonly BindingSource _employeeBinding = new();

	public FormMain(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;

		InitializeComponent();

		dgEmployees.AutoGenerateColumns = false;
		dgEmployees.Columns.Clear();
		dgEmployees.DataSource = _employeeBinding;

		dgEmployees.Columns.Add(new DataGridViewTextBoxColumn
		{
			DataPropertyName = "FullName",
			HeaderText = "ФИО",
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		});
		dgEmployees.Columns.Add(new DataGridViewTextBoxColumn
		{
			DataPropertyName = "PositionName",
			HeaderText = "Должность",
			Width = 250
		});
		dgEmployees.Columns.Add(new DataGridViewTextBoxColumn
		{
			DataPropertyName = "Salary",
			HeaderText = "Оклад",
			Width = 150
		});
		dgEmployees.Columns.Add(new DataGridViewTextBoxColumn
		{
			DataPropertyName = "CreatedAt",
			HeaderText = "Дата и время создания",
			Width = 200
		});
		dgEmployees.Columns.Add(new DataGridViewTextBoxColumn
		{
			DataPropertyName = "UpdatedAt",
			HeaderText = "Дата и время обновления",
			Width = 200
		});
		dgEmployees.Columns.Add(new DataGridViewButtonColumn
		{
			HeaderText = "Просмотр",
			Text = "👁",
			UseColumnTextForButtonValue = true,
			Width = 140
		});
		dgEmployees.Columns.Add(new DataGridViewButtonColumn
		{
			HeaderText = "Редактировать",
			Text = "✎",
			UseColumnTextForButtonValue = true,
			Width = 180
		});
		dgEmployees.Columns.Add(new DataGridViewButtonColumn
		{
			HeaderText = "Удалить",
			Text = "🗑",
			UseColumnTextForButtonValue = true,
			Width = 140
		});
	}

	private async void FormMain_Load(object sender, EventArgs e)
	{
		await LoadEmployeesAsync();
	}

	private async void tbFIO_TextChanged(object sender, EventArgs e)
	{
		await LoadEmployeesAsync();
	}

	private async void btnAdd_Click(object sender, EventArgs e)
	{
		using var scope = _serviceProvider.CreateAsyncScope();
		var form = scope.ServiceProvider.GetRequiredService<FormEdit>();
		form.ShowDialog();

		await LoadEmployeesAsync();
	}

	private async void btExportExcel_Click(object sender, EventArgs e)
	{
		if (dgEmployees.Rows.Count == 0)
		{
			MessageBox.Show("Нет данных для экспорта",
				"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		using (var saveFileDialog = new SaveFileDialog())
		{
			saveFileDialog.Filter = "Excel Workbook|*.xlsx";
			saveFileDialog.FileName = "Employees.xlsx";

			if (saveFileDialog.ShowDialog() != DialogResult.OK)
				return;

			try
			{
				using var scope = _serviceProvider.CreateAsyncScope();
				var unitOfWork = scope.ServiceProvider.GetRequiredService<IAppUnitOfWork>();
				var employees = await unitOfWork.EmployeeRepository.GetAllAsync();

				var viewData = employees.Select(e => new EmployeeExportViewModel
				{
					LastName = e.LastName,
					FirstName = e.FirstName,
					Patronymic = e.Patronymic,
					PositionName = e.Position?.Name,
					Salary = e.Salary,
					CreatedAt = e.CreatedAt.ToString("dd.MM.yyyy HH:mm"),
					UpdatedAt = e.UpdatedAt?.ToString("dd.MM.yyyy HH:mm")
				}).ToList();

				using var workbook = new XLWorkbook();
				var worksheet = workbook.Worksheets.Add("Сотрудники");

				var headers = new[] { "Фамилия", "Имя", "Отчество", "Должность", "Оклад", "Создано", "Обновлено" };
				for (int i = 0; i < headers.Length; i++)
				{
					worksheet.Cell(1, i + 1).Value = headers[i];
					worksheet.Cell(1, i + 1).Style.Font.Bold = true;
				}

				for (int i = 0; i < viewData.Count; i++)
				{
					worksheet.Cell(i + 2, 1).Value = viewData[i].LastName;
					worksheet.Cell(i + 2, 2).Value = viewData[i].FirstName;
					worksheet.Cell(i + 2, 3).Value = viewData[i].Patronymic;
					worksheet.Cell(i + 2, 4).Value = viewData[i].PositionName;
					worksheet.Cell(i + 2, 5).Value = viewData[i].Salary;
					worksheet.Cell(i + 2, 6).Value = viewData[i].CreatedAt;
					worksheet.Cell(i + 2, 7).Value = viewData[i].UpdatedAt;
				}
				worksheet.Columns().AdjustToContents();

				workbook.SaveAs(saveFileDialog.FileName);

				var result = MessageBox.Show(
					"Данные успешно экспортированы в Excel.\nХотите открыть файл?",
					"Успешно",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					var process = new Process
					{
						StartInfo = new ProcessStartInfo
						{
							FileName = saveFileDialog.FileName,
							UseShellExecute = true
						}
					};
					process.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при экспорте: {ex.Message}",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

	private async void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0) return;

		var selectedEmployee = _employeeBinding[e.RowIndex] as EmployeeViewModel;
		if (selectedEmployee == null) return;

		var employeeId = selectedEmployee.Id;

		var columnHeader = dgEmployees.Columns[e.ColumnIndex].HeaderText;

		switch (columnHeader)
		{
			case "Редактировать":
				await ShowFormEdit(employeeId);
				break;

			case "Удалить":
				var confirm = MessageBox.Show("Вы действительно хотите удалить выбранного сотрудника?", "Подтверждение",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirm == DialogResult.Yes)
				{
					await DeleteEmployeesAsync(employeeId);
				}
				break;

			case "Просмотр":
				await ShowFormView(employeeId);
				break;
		}
	}

	private async Task ShowFormEdit(string employeeId)
	{
		var scope = _serviceProvider.CreateAsyncScope();
		var editForm = scope.ServiceProvider.GetRequiredService<FormEdit>();

		await editForm.LoadEmployee(employeeId);

		editForm.FormClosed += (s, e) => scope.Dispose();
		if (editForm.ShowDialog() == DialogResult.OK)
		{
			await LoadEmployeesAsync();
		}
	}

	private async Task ShowFormView(string employeeId)
	{
		var scope = _serviceProvider.CreateAsyncScope();
		var viewForm = scope.ServiceProvider.GetRequiredService<FormView>();

		await viewForm.LoadEmployee(employeeId);

		viewForm.FormClosed += (s, e) => scope.Dispose();
		viewForm.Show();
	}

	private async Task DeleteEmployeesAsync(string employeeId)
	{
		try
		{
			using var scope = _serviceProvider.CreateAsyncScope();
			var unitOfWork = scope.ServiceProvider.GetRequiredService<IAppUnitOfWork>();
			var employee = await unitOfWork.EmployeeRepository.GetByIdAsync(employeeId);
			if (employee != null)
			{
				unitOfWork.EmployeeRepository.Delete(employee);
				await unitOfWork.SaveChangesAsync();
				await LoadEmployeesAsync();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private async Task LoadEmployeesAsync()
	{
		try
		{
			using var scope = _serviceProvider.CreateAsyncScope();
			var unitOfWork = scope.ServiceProvider.GetRequiredService<IAppUnitOfWork>();
			var employees = await unitOfWork.EmployeeRepository.GetByFioAsync(tbFIO.Text.Trim());

			var viewData = employees.Select(e => new EmployeeViewModel
			{
				Id = e.Id,
				FullName = $"{e.LastName} {e.FirstName} {e.Patronymic}",
				PositionName = e.Position?.Name,
				Salary = e.Salary,
				CreatedAt = e.CreatedAt.ToString("dd.MM.yyyy HH:mm"),
				UpdatedAt = e.UpdatedAt?.ToString("dd.MM.yyyy HH:mm")
			}).ToList();

			_employeeBinding.DataSource = viewData;
			_employeeBinding.ResetBindings(false);
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
