namespace EmployeeManagement_WinForms.Payments
{
    partial class PaymentList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonShowResolved;

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
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonShowResolved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewPayments.TabIndex = 0;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(12, 418);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(121, 23);
            this.buttonChangeStatus.TabIndex = 1;
            this.buttonChangeStatus.Text = "Change Status";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Created to Pending",
            "Pending to Done",
            "Cancel Payment"});
            this.comboBoxStatus.Location = new System.Drawing.Point(139, 418);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // buttonShowResolved
            // 
            this.buttonShowResolved.Location = new System.Drawing.Point(647, 418);
            this.buttonShowResolved.Name = "buttonShowResolved";
            this.buttonShowResolved.Size = new System.Drawing.Size(125, 23);
            this.buttonShowResolved.TabIndex = 3;
            this.buttonShowResolved.Text = "Show Resolved";
            this.buttonShowResolved.UseVisualStyleBackColor = true;
            this.buttonShowResolved.Click += new System.EventHandler(this.buttonShowResolved_Click);
            // 
            // PaymentsList
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonShowResolved);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.dataGridViewPayments);
            this.Name = "PaymentsList";
            this.Text = "Payments List";
            this.Load += new System.EventHandler(this.PaymentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
