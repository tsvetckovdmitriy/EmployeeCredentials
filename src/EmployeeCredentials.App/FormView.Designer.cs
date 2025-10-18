namespace EmployeeCredentialsApp
{
	partial class FormView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCancel = new Button();
			lbFirstName = new Label();
			tbLastName = new TextBox();
			tbFirstName = new TextBox();
			lbLastName = new Label();
			tbPatronymic = new TextBox();
			lbPatronymic = new Label();
			lbPosition = new Label();
			lbSalary = new Label();
			nbSalary = new NumericUpDown();
			cbPosition = new ComboBox();
			tbCreatedAt = new TextBox();
			lbCreatedAt = new Label();
			tbUpdatedAt = new TextBox();
			lbUpdatedAt = new Label();
			((System.ComponentModel.ISupportInitialize)nbSalary).BeginInit();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnCancel.Location = new Point(378, 631);
			btnCancel.Margin = new Padding(4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(221, 72);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Закрыть";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// lbFirstName
			// 
			lbFirstName.AutoSize = true;
			lbFirstName.Location = new Point(29, 109);
			lbFirstName.Margin = new Padding(4, 0, 4, 0);
			lbFirstName.Name = "lbFirstName";
			lbFirstName.Size = new Size(55, 30);
			lbFirstName.TabIndex = 4;
			lbFirstName.Text = "Имя";
			// 
			// tbLastName
			// 
			tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbLastName.Font = new Font("Segoe UI", 11F);
			tbLastName.Location = new Point(29, 59);
			tbLastName.Margin = new Padding(4);
			tbLastName.Name = "tbLastName";
			tbLastName.ReadOnly = true;
			tbLastName.Size = new Size(570, 37);
			tbLastName.TabIndex = 5;
			// 
			// tbFirstName
			// 
			tbFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbFirstName.Font = new Font("Segoe UI", 11F);
			tbFirstName.Location = new Point(29, 143);
			tbFirstName.Margin = new Padding(4);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.ReadOnly = true;
			tbFirstName.Size = new Size(570, 37);
			tbFirstName.TabIndex = 7;
			// 
			// lbLastName
			// 
			lbLastName.AutoSize = true;
			lbLastName.Location = new Point(32, 25);
			lbLastName.Margin = new Padding(4, 0, 4, 0);
			lbLastName.Name = "lbLastName";
			lbLastName.Size = new Size(104, 30);
			lbLastName.TabIndex = 6;
			lbLastName.Text = "Фамилия";
			// 
			// tbPatronymic
			// 
			tbPatronymic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbPatronymic.Font = new Font("Segoe UI", 11F);
			tbPatronymic.Location = new Point(29, 228);
			tbPatronymic.Margin = new Padding(4);
			tbPatronymic.Name = "tbPatronymic";
			tbPatronymic.ReadOnly = true;
			tbPatronymic.Size = new Size(570, 37);
			tbPatronymic.TabIndex = 9;
			// 
			// lbPatronymic
			// 
			lbPatronymic.AutoSize = true;
			lbPatronymic.Location = new Point(29, 194);
			lbPatronymic.Margin = new Padding(4, 0, 4, 0);
			lbPatronymic.Name = "lbPatronymic";
			lbPatronymic.Size = new Size(107, 30);
			lbPatronymic.TabIndex = 8;
			lbPatronymic.Text = "Отчество";
			// 
			// lbPosition
			// 
			lbPosition.AutoSize = true;
			lbPosition.Location = new Point(29, 281);
			lbPosition.Margin = new Padding(4, 0, 4, 0);
			lbPosition.Name = "lbPosition";
			lbPosition.Size = new Size(125, 30);
			lbPosition.TabIndex = 10;
			lbPosition.Text = "Должность";
			// 
			// lbSalary
			// 
			lbSalary.AutoSize = true;
			lbSalary.Location = new Point(29, 366);
			lbSalary.Margin = new Padding(4, 0, 4, 0);
			lbSalary.Name = "lbSalary";
			lbSalary.Size = new Size(76, 30);
			lbSalary.TabIndex = 12;
			lbSalary.Text = "Оклад";
			// 
			// nbSalary
			// 
			nbSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			nbSalary.DecimalPlaces = 2;
			nbSalary.Font = new Font("Segoe UI", 11F);
			nbSalary.Location = new Point(29, 399);
			nbSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nbSalary.Name = "nbSalary";
			nbSalary.ReadOnly = true;
			nbSalary.Size = new Size(570, 37);
			nbSalary.TabIndex = 14;
			// 
			// cbPosition
			// 
			cbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cbPosition.Enabled = false;
			cbPosition.FormattingEnabled = true;
			cbPosition.Location = new Point(32, 314);
			cbPosition.Name = "cbPosition";
			cbPosition.Size = new Size(567, 38);
			cbPosition.TabIndex = 15;
			// 
			// tbCreatedAt
			// 
			tbCreatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbCreatedAt.Font = new Font("Segoe UI", 11F);
			tbCreatedAt.Location = new Point(29, 487);
			tbCreatedAt.Margin = new Padding(4);
			tbCreatedAt.Name = "tbCreatedAt";
			tbCreatedAt.ReadOnly = true;
			tbCreatedAt.Size = new Size(570, 37);
			tbCreatedAt.TabIndex = 17;
			// 
			// lbCreatedAt
			// 
			lbCreatedAt.AutoSize = true;
			lbCreatedAt.Location = new Point(29, 453);
			lbCreatedAt.Margin = new Padding(4, 0, 4, 0);
			lbCreatedAt.Name = "lbCreatedAt";
			lbCreatedAt.Size = new Size(246, 30);
			lbCreatedAt.TabIndex = 16;
			lbCreatedAt.Text = "Дата и время создания";
			// 
			// tbUpdatedAt
			// 
			tbUpdatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbUpdatedAt.Font = new Font("Segoe UI", 11F);
			tbUpdatedAt.Location = new Point(29, 570);
			tbUpdatedAt.Margin = new Padding(4);
			tbUpdatedAt.Name = "tbUpdatedAt";
			tbUpdatedAt.ReadOnly = true;
			tbUpdatedAt.Size = new Size(570, 37);
			tbUpdatedAt.TabIndex = 19;
			// 
			// lbUpdatedAt
			// 
			lbUpdatedAt.AutoSize = true;
			lbUpdatedAt.Location = new Point(29, 536);
			lbUpdatedAt.Margin = new Padding(4, 0, 4, 0);
			lbUpdatedAt.Name = "lbUpdatedAt";
			lbUpdatedAt.Size = new Size(278, 30);
			lbUpdatedAt.TabIndex = 18;
			lbUpdatedAt.Text = "Дата и время обновления";
			// 
			// FormView
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(628, 732);
			Controls.Add(tbUpdatedAt);
			Controls.Add(lbUpdatedAt);
			Controls.Add(tbCreatedAt);
			Controls.Add(lbCreatedAt);
			Controls.Add(cbPosition);
			Controls.Add(nbSalary);
			Controls.Add(lbSalary);
			Controls.Add(lbPosition);
			Controls.Add(tbPatronymic);
			Controls.Add(lbPatronymic);
			Controls.Add(tbFirstName);
			Controls.Add(lbLastName);
			Controls.Add(tbLastName);
			Controls.Add(lbFirstName);
			Controls.Add(btnCancel);
			Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormView";
			Padding = new Padding(25);
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Просмотр сотрудника";
			Load += FormEdit_Load;
			((System.ComponentModel.ISupportInitialize)nbSalary).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnCancel;
		private Label lbFirstName;
		private TextBox tbLastName;
		private TextBox tbFirstName;
		private Label lbLastName;
		private TextBox tbPatronymic;
		private Label lbPatronymic;
		private Label lbPosition;
		private Label lbSalary;
		private NumericUpDown nbSalary;
		private ComboBox cbPosition;
		private TextBox tbCreatedAt;
		private Label lbCreatedAt;
		private TextBox tbUpdatedAt;
		private Label lbUpdatedAt;
	}
}
