namespace EmployeeManagement_WinForms.Payments
{
    partial class PaymentList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
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
            dataGridViewPayments = new DataGridView();
            buttonShowResolved = new Button();
            buttonCommit = new Button();
            buttonResolve = new Button();
            buttonRevert = new Button();
            buttonCreatePayment = new Button();
            buttonEditPayment = new Button();
            buttonRemovePayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(12, 12);
            dataGridViewPayments.MultiSelect = false;
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.ReadOnly = true;
            dataGridViewPayments.RowHeadersVisible = false;
            dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPayments.Size = new Size(850, 400);
            dataGridViewPayments.TabIndex = 0;
            dataGridViewPayments.CellFormatting += dataGridViewPayments_CellFormatting_1;
            // 
            // buttonShowResolved
            // 
            buttonShowResolved.Location = new Point(12, 447);
            buttonShowResolved.Name = "buttonShowResolved";
            buttonShowResolved.Size = new Size(125, 23);
            buttonShowResolved.TabIndex = 3;
            buttonShowResolved.Text = "Show Resolved";
            buttonShowResolved.UseVisualStyleBackColor = true;
            buttonShowResolved.Click += buttonShowResolved_Click;
            // 
            // buttonCommit
            // 
            buttonCommit.Location = new Point(12, 418);
            buttonCommit.Name = "buttonCommit";
            buttonCommit.Size = new Size(75, 23);
            buttonCommit.TabIndex = 4;
            buttonCommit.Text = "Commit";
            buttonCommit.UseVisualStyleBackColor = true;
            buttonCommit.Click += buttonCommit_Click;
            // 
            // buttonResolve
            // 
            buttonResolve.Location = new Point(93, 418);
            buttonResolve.Name = "buttonResolve";
            buttonResolve.Size = new Size(75, 23);
            buttonResolve.TabIndex = 5;
            buttonResolve.Text = "Resolve";
            buttonResolve.UseVisualStyleBackColor = true;
            buttonResolve.Click += buttonResolve_Click;
            // 
            // buttonRevert
            // 
            buttonRevert.Location = new Point(174, 418);
            buttonRevert.Name = "buttonRevert";
            buttonRevert.Size = new Size(75, 23);
            buttonRevert.TabIndex = 6;
            buttonRevert.Text = "Revert";
            buttonRevert.UseVisualStyleBackColor = true;
            buttonRevert.Click += buttonRevert_Click;
            // 
            // buttonCreatePayment
            // 
            buttonCreatePayment.Location = new Point(746, 418);
            buttonCreatePayment.Name = "buttonCreatePayment";
            buttonCreatePayment.Size = new Size(116, 23);
            buttonCreatePayment.TabIndex = 7;
            buttonCreatePayment.Text = "Create payment";
            buttonCreatePayment.UseVisualStyleBackColor = true;
            buttonCreatePayment.Click += buttonCreatePayment_Click;
            // 
            // buttonEditPayment
            // 
            buttonEditPayment.Location = new Point(624, 418);
            buttonEditPayment.Name = "buttonEditPayment";
            buttonEditPayment.Size = new Size(116, 23);
            buttonEditPayment.TabIndex = 8;
            buttonEditPayment.Text = "Edit payment";
            buttonEditPayment.UseVisualStyleBackColor = true;
            buttonEditPayment.Click += buttonEditPayment_Click;
            // 
            // buttonRemovePayment
            // 
            buttonRemovePayment.Location = new Point(746, 447);
            buttonRemovePayment.Name = "buttonRemovePayment";
            buttonRemovePayment.Size = new Size(116, 23);
            buttonRemovePayment.TabIndex = 9;
            buttonRemovePayment.Text = "Remove payment";
            buttonRemovePayment.UseVisualStyleBackColor = true;
            buttonRemovePayment.Click += buttonRemovePayment_Click;
            // 
            // PaymentList
            // 
            ClientSize = new Size(874, 479);
            Controls.Add(buttonRemovePayment);
            Controls.Add(buttonEditPayment);
            Controls.Add(buttonCreatePayment);
            Controls.Add(buttonRevert);
            Controls.Add(buttonResolve);
            Controls.Add(buttonCommit);
            Controls.Add(buttonShowResolved);
            Controls.Add(dataGridViewPayments);
            Name = "PaymentList";
            Text = "Payments List";
            Load += PaymentsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
        }

        private Button buttonCommit;
        private Button buttonResolve;
        private Button buttonRevert;
        private Button buttonCreatePayment;
        private Button buttonEditPayment;
        private Button buttonRemovePayment;
    }
}
