namespace EmployeeManagement_WinForms.Employees
{
    partial class EmployeeSalaryModification
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
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.Button buttonSave;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelSalary = new Label();
            numericUpDownSalary = new NumericUpDown();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).BeginInit();
            SuspendLayout();
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(16, 14);
            labelSalary.Margin = new Padding(4, 0, 4, 0);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(41, 15);
            labelSalary.TabIndex = 4;
            labelSalary.Text = "Salary:";
            // 
            // numericUpDownSalary
            // 
            numericUpDownSalary.DecimalPlaces = 2;
            numericUpDownSalary.Location = new Point(118, 12);
            numericUpDownSalary.Margin = new Padding(4, 3, 4, 3);
            numericUpDownSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSalary.Name = "numericUpDownSalary";
            numericUpDownSalary.Size = new Size(233, 23);
            numericUpDownSalary.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(263, 42);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 27);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // EmployeeSalaryModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 78);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownSalary);
            Controls.Add(labelSalary);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmployeeSalaryModification";
            Text = "Employee Salary";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}