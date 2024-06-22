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
            buttonRoles = new Button();
            buttonDeductions = new Button();
            buttonPayments = new Button();
            SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(12, 119);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(230, 101);
            buttonAddEmployee.TabIndex = 9;
            buttonAddEmployee.Text = "Employees";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonRoles
            // 
            buttonRoles.Location = new Point(12, 12);
            buttonRoles.Name = "buttonRoles";
            buttonRoles.Size = new Size(230, 101);
            buttonRoles.TabIndex = 13;
            buttonRoles.Text = "Roles";
            buttonRoles.UseVisualStyleBackColor = true;
            buttonRoles.Click += buttonRoles_Click;
            // 
            // buttonDeductions
            // 
            buttonDeductions.Location = new Point(248, 12);
            buttonDeductions.Name = "buttonDeductions";
            buttonDeductions.Size = new Size(230, 101);
            buttonDeductions.TabIndex = 14;
            buttonDeductions.Text = "Deductions";
            buttonDeductions.UseVisualStyleBackColor = true;
            buttonDeductions.Click += buttonDeductions_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.Location = new Point(248, 119);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new Size(230, 101);
            buttonPayments.TabIndex = 15;
            buttonPayments.Text = "Payments";
            buttonPayments.UseVisualStyleBackColor = true;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 232);
            Controls.Add(buttonPayments);
            Controls.Add(buttonDeductions);
            Controls.Add(buttonRoles);
            Controls.Add(buttonAddEmployee);
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAddEmployee;
        private Button buttonRoles;
        private Button buttonDeductions;
        private Button buttonPayments;
    }
}
