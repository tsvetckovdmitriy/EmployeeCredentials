using EmployeeCredentials.Data.Entities;
using EmployeeCredentials.Data.Interfaces;

namespace EmployeeCredentialsApp;

public partial class FormEdit : Form
{
	private readonly IAppUnitOfWork _unitOfWork;

	private Employee? _employee = null;

	public FormEdit(IAppUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;

		Text = "Добавление сотрудника";

		InitializeComponent();
	}

	private async void FormEdit_Load(object sender, EventArgs e)
	{
		await LoadPositionsAsync();
	}

	private async void btnSave_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(tbLastName.Text))
		{
			MessageBox.Show("Введите фамилию сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			tbLastName.Focus();
			return;
		}

		if (string.IsNullOrWhiteSpace(tbFirstName.Text))
		{
			MessageBox.Show("Введите имя сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			tbFirstName.Focus();
			return;
		}

		if (cbPosition.SelectedValue == null)
		{
			MessageBox.Show("Выберите должность.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			cbPosition.Focus();
			return;
		}

		if (nbSalary.Value <= 0)
		{
			MessageBox.Show("Оклад должен быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			nbSalary.Focus();
			return;
		}

		if (_employee == null)
		{
			var employee = new Employee
			{
				LastName = tbLastName.Text.Trim(),
				FirstName = tbFirstName.Text.Trim(),
				Patronymic = tbPatronymic.Text.Trim(),
				PositionId = (string)cbPosition.SelectedValue,
				Salary = nbSalary.Value,
				CreatedAt = DateTime.Now,
			};

			await _unitOfWork.EmployeeRepository.AddAsync(employee);
		}
		else
		{
			_employee.LastName = tbLastName.Text.Trim();
			_employee.FirstName = tbFirstName.Text.Trim();
			_employee.Patronymic = tbPatronymic.Text.Trim();
			_employee.PositionId = (string)cbPosition.SelectedValue;
			_employee.Salary = nbSalary.Value;
			_employee.UpdatedAt = DateTime.Now;

			_unitOfWork.EmployeeRepository.Update(_employee);
		}

		await _unitOfWork.SaveChangesAsync();

		DialogResult = DialogResult.OK;
		Close();
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

			Text = "Редактирование сотрудника";
			tbLastName.Text = _employee.LastName;
			tbFirstName.Text = _employee.FirstName;
			tbPatronymic.Text = _employee.Patronymic;
			cbPosition.SelectedValue = _employee.PositionId;
			nbSalary.Value = _employee.Salary;

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
