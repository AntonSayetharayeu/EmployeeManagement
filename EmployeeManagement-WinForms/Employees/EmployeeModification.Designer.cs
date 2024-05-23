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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeeRole = new System.Windows.Forms.ComboBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Modify Employee";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Imię";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 56);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PlaceholderText = "Nazwisko";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 23);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(12, 85);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.PlaceholderText = "Wiek";
            this.textBoxAge.Size = new Size(100, 23);
            this.textBoxAge.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 114);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Email";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 4;
            // 
            // comboBoxEmployeeRole
            // 
            this.comboBoxEmployeeRole.FormattingEnabled = true;
            this.comboBoxEmployeeRole.Location = new System.Drawing.Point(186, 85);
            this.comboBoxEmployeeRole.Name = "comboBoxEmployeeRole";
            this.comboBoxEmployeeRole.Size = new System.Drawing.Size(100, 23);
            this.comboBoxEmployeeRole.TabIndex = 5;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 143);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(274, 42);
            this.buttonSaveChanges.TabIndex = 6;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // EmployeeModification
            // 
            this.ClientSize = new System.Drawing.Size(298, 197);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.comboBoxEmployeeRole);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTitle);
            this.Name = "EmployeeModification";
            this.Text = "Modify Employee";
            this.Load += new System.EventHandler(this.EmployeeModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
