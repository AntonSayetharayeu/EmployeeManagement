namespace EmployeeManagement_WinForms.Employees
{
    partial class EmployeeModification
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxEmployeeRole;
        private System.Windows.Forms.Button buttonSaveChanges;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxAge = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxEmployeeRole = new ComboBox();
            buttonSaveChanges = new Button();
            buttonEditSalary = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(100, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Modify Employee";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Imię";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 56);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "Nazwisko";
            textBoxSurname.Size = new Size(100, 23);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(12, 85);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PlaceholderText = "Wiek";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(186, 56);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // comboBoxEmployeeRole
            // 
            comboBoxEmployeeRole.FormattingEnabled = true;
            comboBoxEmployeeRole.Location = new Point(186, 27);
            comboBoxEmployeeRole.Name = "comboBoxEmployeeRole";
            comboBoxEmployeeRole.Size = new Size(100, 23);
            comboBoxEmployeeRole.TabIndex = 5;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(12, 143);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(274, 42);
            buttonSaveChanges.TabIndex = 6;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonEditSalary
            // 
            buttonEditSalary.Location = new Point(186, 95);
            buttonEditSalary.Name = "buttonEditSalary";
            buttonEditSalary.Size = new Size(100, 42);
            buttonEditSalary.TabIndex = 7;
            buttonEditSalary.Text = "Salary change";
            buttonEditSalary.UseVisualStyleBackColor = true;
            buttonEditSalary.Click += buttonEditSalary_Click;
            // 
            // EmployeeModification
            // 
            ClientSize = new Size(298, 197);
            Controls.Add(buttonEditSalary);
            Controls.Add(buttonSaveChanges);
            Controls.Add(comboBoxEmployeeRole);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelTitle);
            Name = "EmployeeModification";
            Text = "Modify Employee";
            Load += EmployeeModification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonEditSalary;
    }
}
