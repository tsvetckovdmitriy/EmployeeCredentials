namespace EmployeeCredentialsApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			labelSearchFIO = new Label();
			btnAdd = new Button();
			tbFIO = new TextBox();
			dgEmployees = new DataGridView();
			FirstName = new DataGridViewTextBoxColumn();
			LastName = new DataGridViewTextBoxColumn();
			Patronymic = new DataGridViewTextBoxColumn();
			Position = new DataGridViewComboBoxColumn();
			Salary = new DataGridViewTextBoxColumn();
			CreatedAt = new DataGridViewTextBoxColumn();
			UpdatedAt = new DataGridViewTextBoxColumn();
			btExportExcel = new Button();
			((System.ComponentModel.ISupportInitialize)dgEmployees).BeginInit();
			SuspendLayout();
			// 
			// labelSearchFIO
			// 
			labelSearchFIO.AutoSize = true;
			labelSearchFIO.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSearchFIO.Location = new Point(36, 34);
			labelSearchFIO.Margin = new Padding(4, 0, 4, 0);
			labelSearchFIO.Name = "labelSearchFIO";
			labelSearchFIO.Size = new Size(168, 30);
			labelSearchFIO.TabIndex = 0;
			labelSearchFIO.Text = "Поиск по ФИО:";
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnAdd.Location = new Point(1340, 14);
			btnAdd.Margin = new Padding(4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(310, 72);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Добавить сотрудника";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// tbFIO
			// 
			tbFIO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbFIO.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tbFIO.Location = new Point(245, 30);
			tbFIO.Margin = new Padding(4);
			tbFIO.Name = "tbFIO";
			tbFIO.Size = new Size(820, 37);
			tbFIO.TabIndex = 2;
			tbFIO.TextChanged += tbFIO_TextChanged;
			// 
			// dgEmployees
			// 
			dgEmployees.AllowUserToAddRows = false;
			dgEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgEmployees.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Patronymic, Position, Salary, CreatedAt, UpdatedAt });
			dgEmployees.Location = new Point(36, 108);
			dgEmployees.Margin = new Padding(4);
			dgEmployees.Name = "dgEmployees";
			dgEmployees.ReadOnly = true;
			dgEmployees.RowHeadersWidth = 62;
			dgEmployees.Size = new Size(1614, 925);
			dgEmployees.TabIndex = 3;
			dgEmployees.CellContentClick += dgEmployees_CellContentClick;
			// 
			// FirstName
			// 
			FirstName.HeaderText = "Фамилия";
			FirstName.MinimumWidth = 8;
			FirstName.Name = "FirstName";
			FirstName.ReadOnly = true;
			FirstName.Width = 200;
			// 
			// LastName
			// 
			LastName.HeaderText = "Имя";
			LastName.MinimumWidth = 8;
			LastName.Name = "LastName";
			LastName.ReadOnly = true;
			LastName.Width = 200;
			// 
			// Patronymic
			// 
			Patronymic.HeaderText = "Отчество";
			Patronymic.MinimumWidth = 8;
			Patronymic.Name = "Patronymic";
			Patronymic.ReadOnly = true;
			Patronymic.Width = 200;
			// 
			// Position
			// 
			Position.HeaderText = "Должность";
			Position.MinimumWidth = 8;
			Position.Name = "Position";
			Position.ReadOnly = true;
			Position.Width = 200;
			// 
			// Salary
			// 
			Salary.HeaderText = "Оклад";
			Salary.MinimumWidth = 8;
			Salary.Name = "Salary";
			Salary.ReadOnly = true;
			Salary.Resizable = DataGridViewTriState.True;
			Salary.SortMode = DataGridViewColumnSortMode.NotSortable;
			Salary.Width = 150;
			// 
			// CreatedAt
			// 
			CreatedAt.HeaderText = "Дата и время создания";
			CreatedAt.MinimumWidth = 8;
			CreatedAt.Name = "CreatedAt";
			CreatedAt.ReadOnly = true;
			CreatedAt.Width = 220;
			// 
			// UpdatedAt
			// 
			UpdatedAt.HeaderText = "Дата и время обновления";
			UpdatedAt.MinimumWidth = 8;
			UpdatedAt.Name = "UpdatedAt";
			UpdatedAt.ReadOnly = true;
			UpdatedAt.Width = 220;
			// 
			// btExportExcel
			// 
			btExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btExportExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btExportExcel.Location = new Point(1080, 14);
			btExportExcel.Margin = new Padding(4);
			btExportExcel.Name = "btExportExcel";
			btExportExcel.Size = new Size(252, 72);
			btExportExcel.TabIndex = 4;
			btExportExcel.Text = "Выгрузить в EXCEL";
			btExportExcel.UseVisualStyleBackColor = true;
			btExportExcel.Click += btExportExcel_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1690, 1073);
			Controls.Add(btExportExcel);
			Controls.Add(dgEmployees);
			Controls.Add(tbFIO);
			Controls.Add(btnAdd);
			Controls.Add(labelSearchFIO);
			Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormMain";
			Text = "Управление учетными данными сотрудников";
			Load += FormMain_Load;
			((System.ComponentModel.ISupportInitialize)dgEmployees).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelSearchFIO;
		private Button btnAdd;
		private TextBox tbFIO;
		private DataGridView dgEmployees;
		private DataGridViewTextBoxColumn FirstName;
		private DataGridViewTextBoxColumn LastName;
		private DataGridViewTextBoxColumn Patronymic;
		private DataGridViewComboBoxColumn Position;
		private DataGridViewTextBoxColumn Salary;
		private DataGridViewTextBoxColumn CreatedAt;
		private DataGridViewTextBoxColumn UpdatedAt;
		private Button btExportExcel;
	}
}
