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
            labelTitle = new Label();
            textBoxRoleName = new TextBox();
            buttonAddRole = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(82, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Add New Role";
            // 
            // textBoxRoleName
            // 
            textBoxRoleName.Location = new Point(12, 27);
            textBoxRoleName.Name = "textBoxRoleName";
            textBoxRoleName.PlaceholderText = "Role Name";
            textBoxRoleName.Size = new Size(260, 23);
            textBoxRoleName.TabIndex = 1;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(12, 56);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(260, 43);
            buttonAddRole.TabIndex = 2;
            buttonAddRole.Text = "Add Role";
            buttonAddRole.UseVisualStyleBackColor = true;
            buttonAddRole.Click += buttonAddRole_Click;
            // 
            // RoleAddition
            // 
            ClientSize = new Size(284, 111);
            Controls.Add(buttonAddRole);
            Controls.Add(textBoxRoleName);
            Controls.Add(labelTitle);
            Name = "RoleAddition";
            Text = "Role Addition";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
