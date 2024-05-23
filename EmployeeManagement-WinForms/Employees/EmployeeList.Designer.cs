namespace EmployeeManagement_WinForms.Employees
{
    partial class EmployeeList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxNameFilter;
        private System.Windows.Forms.TextBox textBoxSurnameFilter;
        private System.Windows.Forms.ComboBox comboBoxRoleFilter;
        private System.Windows.Forms.TextBox textBoxAgeFilter;
        private System.Windows.Forms.ComboBox comboBoxAgeFilterCondition;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.CheckBox checkBoxExactName;
        private System.Windows.Forms.CheckBox checkBoxExactSurname;

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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNameFilter = new System.Windows.Forms.TextBox();
            this.textBoxSurnameFilter = new System.Windows.Forms.TextBox();
            this.comboBoxRoleFilter = new System.Windows.Forms.ComboBox();
            this.textBoxAgeFilter = new System.Windows.Forms.TextBox();
            this.comboBoxAgeFilterCondition = new System.Windows.Forms.ComboBox();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.checkBoxExactName = new System.Windows.Forms.CheckBox();
            this.checkBoxExactSurname = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(560, 250);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 268);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(93, 268);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(174, 268);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxNameFilter
            // 
            this.textBoxNameFilter.Location = new System.Drawing.Point(12, 297);
            this.textBoxNameFilter.Name = "textBoxNameFilter";
            this.textBoxNameFilter.PlaceholderText = "Name";
            this.textBoxNameFilter.Size = new System.Drawing.Size(100, 23);
            this.textBoxNameFilter.TabIndex = 4;
            // 
            // textBoxSurnameFilter
            // 
            this.textBoxSurnameFilter.Location = new System.Drawing.Point(12, 326);
            this.textBoxSurnameFilter.Name = "textBoxSurnameFilter";
            this.textBoxSurnameFilter.PlaceholderText = "Surname";
            this.textBoxSurnameFilter.Size = new System.Drawing.Size(100, 23);
            this.textBoxSurnameFilter.TabIndex = 5;
            // 
            // comboBoxRoleFilter
            // 
            this.comboBoxRoleFilter.FormattingEnabled = true;
            this.comboBoxRoleFilter.Location = new System.Drawing.Point(12, 355);
            this.comboBoxRoleFilter.Name = "comboBoxRoleFilter";
            this.comboBoxRoleFilter.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRoleFilter.TabIndex = 6;
            // 
            // textBoxAgeFilter
            // 
            this.textBoxAgeFilter.Location = new System.Drawing.Point(139, 297);
            this.textBoxAgeFilter.Name = "textBoxAgeFilter";
            this.textBoxAgeFilter.PlaceholderText = "Age";
            this.textBoxAgeFilter.Size = new System.Drawing.Size(100, 23);
            this.textBoxAgeFilter.TabIndex = 7;
            // 
            // comboBoxAgeFilterCondition
            // 
            this.comboBoxAgeFilterCondition.FormattingEnabled = true;
            this.comboBoxAgeFilterCondition.Items.AddRange(new object[] {
            "More",
            "Less",
            "Equals"});
            this.comboBoxAgeFilterCondition.Location = new System.Drawing.Point(139, 326);
            this.comboBoxAgeFilterCondition.Name = "comboBoxAgeFilterCondition";
            this.comboBoxAgeFilterCondition.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAgeFilterCondition.TabIndex = 8;
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Location = new System.Drawing.Point(174, 355);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(86, 23);
            this.buttonApplyFilters.TabIndex = 9;
            this.buttonApplyFilters.Text = "Apply Filters";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // checkBoxExactName
            // 
            this.checkBoxExactName.AutoSize = true;
            this.checkBoxExactName.Location = new System.Drawing.Point(245, 299);
            this.checkBoxExactName.Name = "checkBoxExactName";
            this.checkBoxExactName.Size = new System.Drawing.Size(90, 19);
            this.checkBoxExactName.TabIndex = 10;
            this.checkBoxExactName.Text = "Exact Name";
            this.checkBoxExactName.UseVisualStyleBackColor = true;
            // 
            // checkBoxExactSurname
            // 
            this.checkBoxExactSurname.AutoSize = true;
            this.checkBoxExactSurname.Location = new System.Drawing.Point(245, 328);
            this.checkBoxExactSurname.Name = "checkBoxExactSurname";
            this.checkBoxExactSurname.Size = new System.Drawing.Size(106, 19);
            this.checkBoxExactSurname.TabIndex = 11;
            this.checkBoxExactSurname.Text = "Exact Surname";
            this.checkBoxExactSurname.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.checkBoxExactSurname);
            this.Controls.Add(this.checkBoxExactName);
            this.Controls.Add(this.buttonApplyFilters);
            this.Controls.Add(this.comboBoxAgeFilterCondition);
            this.Controls.Add(this.textBoxAgeFilter);
            this.Controls.Add(this.comboBoxRoleFilter);
            this.Controls.Add(this.textBoxSurnameFilter);
            this.Controls.Add(this.textBoxNameFilter);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeeList";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
