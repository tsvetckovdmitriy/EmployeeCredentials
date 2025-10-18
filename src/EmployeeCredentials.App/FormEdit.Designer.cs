namespace EmployeeCredentialsApp
{
	partial class FormEdit
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
			btnSave = new Button();
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
			((System.ComponentModel.ISupportInitialize)nbSalary).BeginInit();
			SuspendLayout();
			// 
			// btnSave
			// 
			btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnSave.Location = new Point(149, 473);
			btnSave.Margin = new Padding(4);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(221, 72);
			btnSave.TabIndex = 2;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnCancel.Location = new Point(378, 473);
			btnCancel.Margin = new Padding(4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(221, 72);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Отмена";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// lbFirstName
			// 
			lbFirstName.AutoSize = true;
			lbFirstName.Location = new Point(29, 109);
			lbFirstName.Margin = new Padding(4, 0, 4, 0);
			lbFirstName.Name = "lbFirstName";
			lbFirstName.Size = new Size(70, 30);
			lbFirstName.TabIndex = 4;
			lbFirstName.Text = "Имя *";
			// 
			// tbLastName
			// 
			tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbLastName.Font = new Font("Segoe UI", 11F);
			tbLastName.Location = new Point(29, 59);
			tbLastName.Margin = new Padding(4);
			tbLastName.Name = "tbLastName";
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
			tbFirstName.Size = new Size(570, 37);
			tbFirstName.TabIndex = 7;
			// 
			// lbLastName
			// 
			lbLastName.AutoSize = true;
			lbLastName.Location = new Point(32, 25);
			lbLastName.Margin = new Padding(4, 0, 4, 0);
			lbLastName.Name = "lbLastName";
			lbLastName.Size = new Size(119, 30);
			lbLastName.TabIndex = 6;
			lbLastName.Text = "Фамилия *";
			// 
			// tbPatronymic
			// 
			tbPatronymic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbPatronymic.Font = new Font("Segoe UI", 11F);
			tbPatronymic.Location = new Point(29, 228);
			tbPatronymic.Margin = new Padding(4);
			tbPatronymic.Name = "tbPatronymic";
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
			lbPosition.Size = new Size(140, 30);
			lbPosition.TabIndex = 10;
			lbPosition.Text = "Должность *";
			// 
			// lbSalary
			// 
			lbSalary.AutoSize = true;
			lbSalary.Location = new Point(29, 366);
			lbSalary.Margin = new Padding(4, 0, 4, 0);
			lbSalary.Name = "lbSalary";
			lbSalary.Size = new Size(91, 30);
			lbSalary.TabIndex = 12;
			lbSalary.Text = "Оклад *";
			// 
			// nbSalary
			// 
			nbSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			nbSalary.DecimalPlaces = 2;
			nbSalary.Font = new Font("Segoe UI", 11F);
			nbSalary.Location = new Point(29, 399);
			nbSalary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			nbSalary.Name = "nbSalary";
			nbSalary.Size = new Size(570, 37);
			nbSalary.TabIndex = 14;
			// 
			// cbPosition
			// 
			cbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPosition.Location = new Point(32, 314);
			cbPosition.Name = "cbPosition";
			cbPosition.Size = new Size(567, 38);
			cbPosition.TabIndex = 15;
			// 
			// FormEdit
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(628, 574);
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
			Controls.Add(btnSave);
			Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormEdit";
			Padding = new Padding(25);
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormEdit";
			Load += FormEdit_Load;
			((System.ComponentModel.ISupportInitialize)nbSalary).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSave;
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
	}
}
