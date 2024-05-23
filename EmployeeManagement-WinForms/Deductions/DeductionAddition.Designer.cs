namespace EmployeeManagement_WinForms.Deductions
{
    partial class DeductionAddition
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxIsPercentage;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonAddDeduction;

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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxIsPercentage = new System.Windows.Forms.CheckBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonAddDeduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Deduction";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.Size = new System.Drawing.Size(260, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 56);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PlaceholderText = "Description";
            this.textBoxDescription.Size = new System.Drawing.Size(260, 23);
            this.textBoxDescription.TabIndex = 2;
            // 
            // checkBoxIsPercentage
            // 
            this.checkBoxIsPercentage.AutoSize = true;
            this.checkBoxIsPercentage.Location = new System.Drawing.Point(12, 85);
            this.checkBoxIsPercentage.Name = "checkBoxIsPercentage";
            this.checkBoxIsPercentage.Size = new System.Drawing.Size(101, 19);
            this.checkBoxIsPercentage.TabIndex = 3;
            this.checkBoxIsPercentage.Text = "Is Percentage";
            this.checkBoxIsPercentage.UseVisualStyleBackColor = true;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 110);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.PlaceholderText = "Value";
            this.textBoxValue.Size = new System.Drawing.Size(260, 23);
            this.textBoxValue.TabIndex = 4;
            // 
            // buttonAddDeduction
            // 
            this.buttonAddDeduction.Location = new System.Drawing.Point(12, 139);
            this.buttonAddDeduction.Name = "buttonAddDeduction";
            this.buttonAddDeduction.Size = new System.Drawing.Size(260, 42);
            this.buttonAddDeduction.TabIndex = 5;
            this.buttonAddDeduction.Text = "Add Deduction";
            this.buttonAddDeduction.UseVisualStyleBackColor = true;
            this.buttonAddDeduction.Click += new System.EventHandler(this.buttonAddDeduction_Click);
            // 
            // DeductionAddition
            // 
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.buttonAddDeduction);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.checkBoxIsPercentage);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTitle);
            this.Name = "DeductionAddition";
            this.Text = "Deduction Addition";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
