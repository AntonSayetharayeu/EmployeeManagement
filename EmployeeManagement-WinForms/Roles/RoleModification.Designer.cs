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
            labelTitle = new Label();
            textBoxName = new TextBox();
            buttonSaveChanges = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(71, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Modify Role";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Role Name";
            textBoxName.Size = new Size(260, 23);
            textBoxName.TabIndex = 1;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(12, 56);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(260, 42);
            buttonSaveChanges.TabIndex = 2;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // RoleModification
            // 
            ClientSize = new Size(284, 111);
            Controls.Add(buttonSaveChanges);
            Controls.Add(textBoxName);
            Controls.Add(labelTitle);
            Name = "RoleModification";
            Text = "Role Modification";
            Load += RoleModification_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}