namespace EmployeeManagement_WinForms
{
    partial class MainMenu
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
            buttonAddEmployee = new Button();
            textBoxLogin = new TextBox();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            buttonRoles = new Button();
            buttonDeductions = new Button();
            buttonPayments = new Button();
            SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(224, 283);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(100, 32);
            buttonAddEmployee.TabIndex = 9;
            buttonAddEmployee.Text = "Employees";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 12);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Login";
            textBoxLogin.Size = new Size(100, 23);
            textBoxLogin.TabIndex = 10;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 70);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 32);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 41);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 12;
            // 
            // buttonRoles
            // 
            buttonRoles.Location = new Point(12, 283);
            buttonRoles.Name = "buttonRoles";
            buttonRoles.Size = new Size(100, 32);
            buttonRoles.TabIndex = 13;
            buttonRoles.Text = "Roles";
            buttonRoles.UseVisualStyleBackColor = true;
            buttonRoles.Click += buttonRoles_Click;
            // 
            // buttonDeductions
            // 
            buttonDeductions.Location = new Point(118, 283);
            buttonDeductions.Name = "buttonDeductions";
            buttonDeductions.Size = new Size(100, 32);
            buttonDeductions.TabIndex = 14;
            buttonDeductions.Text = "Deductions";
            buttonDeductions.UseVisualStyleBackColor = true;
            buttonDeductions.Click += buttonDeductions_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.Location = new Point(330, 283);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new Size(100, 32);
            buttonPayments.TabIndex = 15;
            buttonPayments.Text = "Payments";
            buttonPayments.UseVisualStyleBackColor = true;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 327);
            Controls.Add(buttonPayments);
            Controls.Add(buttonDeductions);
            Controls.Add(buttonRoles);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonAddEmployee);
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddEmployee;
        private TextBox textBoxLogin;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private Button buttonRoles;
        private Button buttonDeductions;
        private Button buttonPayments;
    }
}
