namespace EmployeeManagement_WinForms.Roles
{
    partial class RoleList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;

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
            dataGridViewRoles = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Location = new Point(12, 12);
            dataGridViewRoles.MultiSelect = false;
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.ReadOnly = true;
            dataGridViewRoles.RowHeadersVisible = false;
            dataGridViewRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoles.Size = new Size(339, 349);
            dataGridViewRoles.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(357, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(357, 41);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(357, 70);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // RoleList
            // 
            ClientSize = new Size(444, 373);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewRoles);
            Name = "RoleList";
            Text = "Role List";
            Load += RoleList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            ResumeLayout(false);
        }
    }
}
