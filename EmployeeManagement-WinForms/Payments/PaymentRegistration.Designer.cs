namespace EmployeeManagement_WinForms.Payments
{
    partial class PaymentRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEmployees = new ListBox();
            labelEmployees = new Label();
            labelDeduction = new Label();
            listBoxDeductions = new ListBox();
            listBoxSelectedDeductions = new ListBox();
            buttonSelect = new Button();
            buttonSelectAll = new Button();
            buttonUnselect = new Button();
            buttonUnselectAll = new Button();
            checkBoxTaxes = new CheckBox();
            checkBoxBonuses = new CheckBox();
            labelDefault = new Label();
            labelDefaultValue = new Label();
            labelTaxValue = new Label();
            labelTax = new Label();
            labelBonusValue = new Label();
            labelBonus = new Label();
            buttonCreatePayment = new Button();
            labelTotal = new Label();
            labelTotalValue = new Label();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(12, 27);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(211, 154);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // labelEmployees
            // 
            labelEmployees.AutoSize = true;
            labelEmployees.Location = new Point(12, 9);
            labelEmployees.Name = "labelEmployees";
            labelEmployees.Size = new Size(96, 15);
            labelEmployees.TabIndex = 1;
            labelEmployees.Text = "Select employee:";
            // 
            // labelDeduction
            // 
            labelDeduction.AutoSize = true;
            labelDeduction.Location = new Point(12, 203);
            labelDeduction.Name = "labelDeduction";
            labelDeduction.Size = new Size(103, 15);
            labelDeduction.TabIndex = 2;
            labelDeduction.Text = "Select deductions:";
            // 
            // listBoxDeductions
            // 
            listBoxDeductions.FormattingEnabled = true;
            listBoxDeductions.ItemHeight = 15;
            listBoxDeductions.Location = new Point(12, 221);
            listBoxDeductions.Name = "listBoxDeductions";
            listBoxDeductions.Size = new Size(211, 169);
            listBoxDeductions.TabIndex = 3;
            // 
            // listBoxSelectedDeductions
            // 
            listBoxSelectedDeductions.FormattingEnabled = true;
            listBoxSelectedDeductions.ItemHeight = 15;
            listBoxSelectedDeductions.Location = new Point(286, 221);
            listBoxSelectedDeductions.Name = "listBoxSelectedDeductions";
            listBoxSelectedDeductions.Size = new Size(211, 169);
            listBoxSelectedDeductions.TabIndex = 4;
            // 
            // buttonSelect
            // 
            buttonSelect.Font = new Font("Segoe UI", 12F);
            buttonSelect.Location = new Point(229, 221);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(51, 30);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = ">";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Font = new Font("Segoe UI", 12F);
            buttonSelectAll.Location = new Point(229, 257);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(51, 30);
            buttonSelectAll.TabIndex = 6;
            buttonSelectAll.Text = ">>";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // buttonUnselect
            // 
            buttonUnselect.Font = new Font("Segoe UI", 12F);
            buttonUnselect.Location = new Point(229, 360);
            buttonUnselect.Name = "buttonUnselect";
            buttonUnselect.Size = new Size(51, 30);
            buttonUnselect.TabIndex = 7;
            buttonUnselect.Text = "<";
            buttonUnselect.UseVisualStyleBackColor = true;
            buttonUnselect.Click += buttonUnselect_Click;
            // 
            // buttonUnselectAll
            // 
            buttonUnselectAll.Font = new Font("Segoe UI", 12F);
            buttonUnselectAll.Location = new Point(229, 324);
            buttonUnselectAll.Name = "buttonUnselectAll";
            buttonUnselectAll.Size = new Size(51, 30);
            buttonUnselectAll.TabIndex = 8;
            buttonUnselectAll.Text = "<<";
            buttonUnselectAll.UseVisualStyleBackColor = true;
            buttonUnselectAll.Click += buttonUnselectAll_Click;
            // 
            // checkBoxTaxes
            // 
            checkBoxTaxes.AutoSize = true;
            checkBoxTaxes.Location = new Point(12, 396);
            checkBoxTaxes.Name = "checkBoxTaxes";
            checkBoxTaxes.Size = new Size(54, 19);
            checkBoxTaxes.TabIndex = 10;
            checkBoxTaxes.Text = "Taxes";
            checkBoxTaxes.UseVisualStyleBackColor = true;
            checkBoxTaxes.CheckedChanged += checkBoxTaxes_CheckedChanged;
            // 
            // checkBoxBonuses
            // 
            checkBoxBonuses.AutoSize = true;
            checkBoxBonuses.Location = new Point(72, 396);
            checkBoxBonuses.Name = "checkBoxBonuses";
            checkBoxBonuses.Size = new Size(70, 19);
            checkBoxBonuses.TabIndex = 11;
            checkBoxBonuses.Text = "Bonuses";
            checkBoxBonuses.UseVisualStyleBackColor = true;
            checkBoxBonuses.CheckedChanged += checkBoxBonuses_CheckedChanged;
            // 
            // labelDefault
            // 
            labelDefault.AutoSize = true;
            labelDefault.Location = new Point(285, 108);
            labelDefault.Name = "labelDefault";
            labelDefault.Size = new Size(76, 15);
            labelDefault.TabIndex = 12;
            labelDefault.Text = "Default Value";
            // 
            // labelDefaultValue
            // 
            labelDefaultValue.AutoSize = true;
            labelDefaultValue.Location = new Point(367, 108);
            labelDefaultValue.Name = "labelDefaultValue";
            labelDefaultValue.Size = new Size(0, 15);
            labelDefaultValue.TabIndex = 13;
            // 
            // labelTaxValue
            // 
            labelTaxValue.AutoSize = true;
            labelTaxValue.ForeColor = Color.DarkRed;
            labelTaxValue.Location = new Point(367, 123);
            labelTaxValue.Name = "labelTaxValue";
            labelTaxValue.Size = new Size(0, 15);
            labelTaxValue.TabIndex = 15;
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Location = new Point(285, 123);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(55, 15);
            labelTax.TabIndex = 14;
            labelTax.Text = "Tax Value";
            // 
            // labelBonusValue
            // 
            labelBonusValue.AutoSize = true;
            labelBonusValue.ForeColor = Color.Green;
            labelBonusValue.Location = new Point(367, 138);
            labelBonusValue.Name = "labelBonusValue";
            labelBonusValue.Size = new Size(0, 15);
            labelBonusValue.TabIndex = 17;
            // 
            // labelBonus
            // 
            labelBonus.AutoSize = true;
            labelBonus.Location = new Point(285, 138);
            labelBonus.Name = "labelBonus";
            labelBonus.Size = new Size(71, 15);
            labelBonus.TabIndex = 16;
            labelBonus.Text = "Bonus Value";
            // 
            // buttonCreatePayment
            // 
            buttonCreatePayment.Location = new Point(266, 27);
            buttonCreatePayment.Name = "buttonCreatePayment";
            buttonCreatePayment.Size = new Size(231, 56);
            buttonCreatePayment.TabIndex = 18;
            buttonCreatePayment.Text = "Create payment";
            buttonCreatePayment.UseVisualStyleBackColor = true;
            buttonCreatePayment.Click += buttonCreatePayment_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(286, 166);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(67, 15);
            labelTotal.TabIndex = 19;
            labelTotal.Text = "Total Value";
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotalValue.ForeColor = SystemColors.ControlText;
            labelTotalValue.Location = new Point(367, 166);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(0, 15);
            labelTotalValue.TabIndex = 20;
            // 
            // PaymentAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 426);
            Controls.Add(labelTotalValue);
            Controls.Add(labelTotal);
            Controls.Add(buttonCreatePayment);
            Controls.Add(labelBonusValue);
            Controls.Add(labelBonus);
            Controls.Add(labelTaxValue);
            Controls.Add(labelTax);
            Controls.Add(labelDefaultValue);
            Controls.Add(labelDefault);
            Controls.Add(checkBoxBonuses);
            Controls.Add(checkBoxTaxes);
            Controls.Add(buttonUnselectAll);
            Controls.Add(buttonUnselect);
            Controls.Add(buttonSelectAll);
            Controls.Add(buttonSelect);
            Controls.Add(listBoxSelectedDeductions);
            Controls.Add(listBoxDeductions);
            Controls.Add(labelDeduction);
            Controls.Add(labelEmployees);
            Controls.Add(listBoxEmployees);
            Name = "PaymentAddition";
            Text = "PaymentAddition";
            Load += PaymentAddition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEmployees;
        private Label labelEmployees;
        private Label labelDeduction;
        private ListBox listBoxDeductions;
        private ListBox listBoxSelectedDeductions;
        private Button buttonSelect;
        private Button buttonSelectAll;
        private Button buttonUnselect;
        private Button buttonUnselectAll;
        private CheckBox checkBoxTaxes;
        private CheckBox checkBoxBonuses;
        private Label labelDefault;
        private Label labelDefaultValue;
        private Label labelTaxValue;
        private Label labelTax;
        private Label labelBonusValue;
        private Label labelBonus;
        private Button buttonCreatePayment;
        private Label labelTotal;
        private Label labelTotalValue;
    }
}