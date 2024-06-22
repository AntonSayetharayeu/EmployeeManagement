namespace EmployeeManagement_WinForms.Deductions
{
    partial class DeductionModification
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxIsPercentage;
        private System.Windows.Forms.TextBox textBoxValue;
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
            textBoxDescription = new TextBox();
            checkBoxIsPercentage = new CheckBox();
            textBoxValue = new TextBox();
            buttonSaveChanges = new Button();
            checkBoxDeductionType = new CheckBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(103, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Modify Deduction";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(260, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 56);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Description";
            textBoxDescription.Size = new Size(260, 23);
            textBoxDescription.TabIndex = 2;
            // 
            // checkBoxIsPercentage
            // 
            checkBoxIsPercentage.AutoSize = true;
            checkBoxIsPercentage.Location = new Point(12, 85);
            checkBoxIsPercentage.Name = "checkBoxIsPercentage";
            checkBoxIsPercentage.Size = new Size(96, 19);
            checkBoxIsPercentage.TabIndex = 3;
            checkBoxIsPercentage.Text = "Is Percentage";
            checkBoxIsPercentage.UseVisualStyleBackColor = true;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(12, 110);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.PlaceholderText = "Value";
            textBoxValue.Size = new Size(260, 23);
            textBoxValue.TabIndex = 4;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(12, 139);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(260, 42);
            buttonSaveChanges.TabIndex = 5;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // checkBoxDeductionType
            // 
            checkBoxDeductionType.AutoSize = true;
            checkBoxDeductionType.Location = new Point(202, 85);
            checkBoxDeductionType.Name = "checkBoxDeductionType";
            checkBoxDeductionType.Size = new Size(70, 19);
            checkBoxDeductionType.TabIndex = 7;
            checkBoxDeductionType.Text = "Is Bonus";
            checkBoxDeductionType.UseVisualStyleBackColor = true;
            // 
            // DeductionModification
            // 
            ClientSize = new Size(284, 201);
            Controls.Add(checkBoxDeductionType);
            Controls.Add(buttonSaveChanges);
            Controls.Add(textBoxValue);
            Controls.Add(checkBoxIsPercentage);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelTitle);
            Name = "DeductionModification";
            Text = "Deduction Modification";
            Load += DeductionModification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox checkBoxDeductionType;
    }
}
