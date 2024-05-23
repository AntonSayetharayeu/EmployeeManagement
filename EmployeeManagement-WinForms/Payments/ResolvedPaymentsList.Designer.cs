namespace EmployeeManagement_WinForms.Payments
{
    partial class ResolvedPaymentsList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewResolvedPayments;

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
            this.dataGridViewResolvedPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResolvedPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResolvedPayments
            // 
            this.dataGridViewResolvedPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResolvedPayments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewResolvedPayments.Name = "dataGridViewResolvedPayments";
            this.dataGridViewResolvedPayments.Size = new System.Drawing.Size(760, 437);
            this.dataGridViewResolvedPayments.TabIndex = 0;
            // 
            // ResolvedPaymentsList
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewResolvedPayments);
            this.Name = "ResolvedPaymentsList";
            this.Text = "Resolved Payments List";
            this.Load += new System.EventHandler(this.ResolvedPaymentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResolvedPayments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
