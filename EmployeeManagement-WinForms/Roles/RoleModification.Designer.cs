namespace EmployeeManagement_WinForms.Roles
{
    partial class RoleModification
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
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
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Modify Role";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 56);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(260, 42);
            this.buttonSaveChanges.TabIndex = 2;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // RoleModification
            // 
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTitle);
            this.Name = "RoleModification";
            this.Text = "Role Modification";
            this.Load += new System.EventHandler(this.RoleModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}