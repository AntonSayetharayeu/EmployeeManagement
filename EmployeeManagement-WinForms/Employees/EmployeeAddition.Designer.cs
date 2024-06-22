namespace EmployeeManagement_WinForms.Employees
{
    partial class EmployeeAddition
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
            labelTitle = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxAge = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxEmployeeRole = new ComboBox();
            buttonAddEmployee = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(102, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Dodaj pracownika";
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
            comboBoxEmployeeRole.TabIndex = 7;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(12, 127);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(274, 42);
            buttonAddEmployee.TabIndex = 8;
            buttonAddEmployee.Text = "Add employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // EmployeeAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(298, 181);
            Controls.Add(buttonAddEmployee);
            Controls.Add(comboBoxEmployeeRole);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelTitle);
            Name = "EmployeeAddition";
            Text = "EmployeeAddition";
            Load += EmployeeAddition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxAge;
        private TextBox textBoxEmail;
        private ComboBox comboBoxEmployeeRole;
        private Button buttonAddEmployee;
    }
}