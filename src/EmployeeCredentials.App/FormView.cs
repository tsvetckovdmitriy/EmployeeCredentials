using EmployeeCredentials.Data.Entities;
using EmployeeCredentials.Data.Interfaces;

namespace EmployeeCredentialsApp;

public partial class FormView : Form
{
	private readonly IAppUnitOfWork _unitOfWork;

	private Employee? _employee = null;

	public FormView(IAppUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;

		InitializeComponent();
	}

	private async void FormEdit_Load(object sender, EventArgs e)
	{
		await LoadPositionsAsync();
	}


	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	public async Task<bool> LoadEmployee(string id)
	{
		try
		{
			_employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);

			if (_employee == null)
			{
				MessageBox.Show($"Сотрудник не найден",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			tbFirstName.Text = _employee.FirstName;
			tbLastName.Text = _employee.LastName;
			tbPatronymic.Text = _employee.Patronymic;
			cbPosition.SelectedValue = _employee.PositionId;
			nbSalary.Value = _employee.Salary;

			tbCreatedAt.Text = _employee.CreatedAt.ToString("dd.MM.yyyy HH:mm");
			tbUpdatedAt.Text = _employee.UpdatedAt?.ToString("dd.MM.yyyy HH:mm");

			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при загрузке сотрудника: {ex.Message}",
				"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}

	private async Task LoadPositionsAsync()
	{
		try
		{
			var positions = await _unitOfWork.PositionRepository.GetAllAsync();

			cbPosition.DisplayMember = "Name";
			cbPosition.ValueMember = "Id";
			cbPosition.DataSource = positions;

			if (_employee != null)
			{
				cbPosition.SelectedValue = _employee.PositionId;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при загрузке должностей: {ex.Message}",
				"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
