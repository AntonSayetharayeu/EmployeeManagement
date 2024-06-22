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
            dataGridViewResolvedPayments = new DataGridView();
            buttonCopyPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResolvedPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResolvedPayments
            // 
            dataGridViewResolvedPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResolvedPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResolvedPayments.Location = new Point(12, 12);
            dataGridViewResolvedPayments.Name = "dataGridViewResolvedPayments";
            dataGridViewResolvedPayments.RowHeadersVisible = false;
            dataGridViewResolvedPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResolvedPayments.Size = new Size(760, 437);
            dataGridViewResolvedPayments.TabIndex = 0;
            dataGridViewResolvedPayments.CellFormatting += DataGridViewPayments_CellFormatting;
            // 
            // buttonCopyPayment
            // 
            buttonCopyPayment.Location = new Point(12, 455);
            buttonCopyPayment.Name = "buttonCopyPayment";
            buttonCopyPayment.Size = new Size(125, 23);
            buttonCopyPayment.TabIndex = 4;
            buttonCopyPayment.Text = "Copy payment";
            buttonCopyPayment.UseVisualStyleBackColor = true;
            buttonCopyPayment.Click += buttonCopyPayment_Click;
            // 
            // ResolvedPaymentsList
            // 
            ClientSize = new Size(784, 487);
            Controls.Add(buttonCopyPayment);
            Controls.Add(dataGridViewResolvedPayments);
            Name = "ResolvedPaymentsList";
            Text = "Resolved Payments List";
            Load += ResolvedPaymentsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResolvedPayments).EndInit();
            ResumeLayout(false);
        }

        private Button buttonCopyPayment;
    }
}
