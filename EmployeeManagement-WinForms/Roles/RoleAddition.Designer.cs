namespace EmployeeManagement_WinForms.Roles
{
    partial class RoleAddition
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.Button buttonAddRole;

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
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add New Role";
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Location = new System.Drawing.Point(12, 27);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.PlaceholderText = "Role Name";
            this.textBoxRoleName.Size = new System.Drawing.Size(100, 23);
            this.textBoxRoleName.TabIndex = 1;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Location = new System.Drawing.Point(12, 56);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(100, 23);
            this.buttonAddRole.TabIndex = 2;
            this.buttonAddRole.Text = "Add Role";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // RoleAddition
            // 
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.buttonAddRole);
            this.Controls.Add(this.textBoxRoleName);
            this.Controls.Add(this.labelTitle);
            this.Name = "RoleAddition";
            this.Text = "Role Addition";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
