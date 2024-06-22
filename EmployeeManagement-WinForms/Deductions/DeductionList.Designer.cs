namespace EmployeeManagement_WinForms.Deductions
{
    partial class DeductionList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewDeductions;
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
            dataGridViewDeductions = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeductions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDeductions
            // 
            dataGridViewDeductions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDeductions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeductions.Location = new Point(12, 12);
            dataGridViewDeductions.MultiSelect = false;
            dataGridViewDeductions.Name = "dataGridViewDeductions";
            dataGridViewDeductions.ReadOnly = true;
            dataGridViewDeductions.RowHeadersVisible = false;
            dataGridViewDeductions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDeductions.Size = new Size(560, 250);
            dataGridViewDeductions.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 268);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(93, 268);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(174, 268);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DeductionList
            // 
            ClientSize = new Size(584, 311);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewDeductions);
            Name = "DeductionList";
            Text = "Deduction List";
            Load += DeductionList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeductions).EndInit();
            ResumeLayout(false);
        }
    }
}
