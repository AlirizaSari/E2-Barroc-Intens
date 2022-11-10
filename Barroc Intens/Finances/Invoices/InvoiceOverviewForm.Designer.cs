namespace Barroc_Intens
{
    partial class InvoiceOverviewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceOverviewForm));
            this.btnBackToFinanceDashboard = new System.Windows.Forms.Button();
            this.dgvPaidInvoices = new System.Windows.Forms.DataGridView();
            this.PaymentTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPaidInvoices = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotPaidInvoices = new System.Windows.Forms.DataGridView();
            this.customInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaidInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToFinanceDashboard
            // 
            this.btnBackToFinanceDashboard.Location = new System.Drawing.Point(644, 12);
            this.btnBackToFinanceDashboard.Name = "btnBackToFinanceDashboard";
            this.btnBackToFinanceDashboard.Size = new System.Drawing.Size(144, 56);
            this.btnBackToFinanceDashboard.TabIndex = 0;
            this.btnBackToFinanceDashboard.Text = "Terug naar finance dashboard";
            this.btnBackToFinanceDashboard.UseVisualStyleBackColor = true;
            this.btnBackToFinanceDashboard.Click += new System.EventHandler(this.btnBackToFinanceDashboard_Click);
            // 
            // dgvPaidInvoices
            // 
            this.dgvPaidInvoices.AllowUserToAddRows = false;
            this.dgvPaidInvoices.AllowUserToDeleteRows = false;
            this.dgvPaidInvoices.AutoGenerateColumns = false;
            this.dgvPaidInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaidInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaidInvoices.ColumnHeadersVisible = false;
            this.dgvPaidInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.paidAtDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn13});
            this.dgvPaidInvoices.DataSource = this.customInvoiceBindingSource;
            this.dgvPaidInvoices.Location = new System.Drawing.Point(40, 105);
            this.dgvPaidInvoices.Name = "dgvPaidInvoices";
            this.dgvPaidInvoices.ReadOnly = true;
            this.dgvPaidInvoices.RowHeadersWidth = 51;
            this.dgvPaidInvoices.RowTemplate.Height = 24;
            this.dgvPaidInvoices.Size = new System.Drawing.Size(297, 364);
            this.dgvPaidInvoices.TabIndex = 1;
            this.dgvPaidInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaidInvoices_CellClick);
            // 
            // PaymentTerm
            // 
            this.PaymentTerm.DataPropertyName = "PaymentTerm";
            this.PaymentTerm.HeaderText = "PaymentTerm";
            this.PaymentTerm.MinimumWidth = 6;
            this.PaymentTerm.Name = "PaymentTerm";
            this.PaymentTerm.ReadOnly = true;
            this.PaymentTerm.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn1.HeaderText = "Company";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn2.HeaderText = "Company";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // lblPaidInvoices
            // 
            this.lblPaidInvoices.AutoSize = true;
            this.lblPaidInvoices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidInvoices.Location = new System.Drawing.Point(36, 82);
            this.lblPaidInvoices.Name = "lblPaidInvoices";
            this.lblPaidInvoices.Size = new System.Drawing.Size(127, 20);
            this.lblPaidInvoices.TabIndex = 3;
            this.lblPaidInvoices.Text = "Betaalde invoices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Niet betaalde invoices";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn4.HeaderText = "Company";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn5.HeaderText = "Company";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn6.HeaderText = "Company";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn7.HeaderText = "Company";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn8.HeaderText = "Company";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn9.HeaderText = "Company";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn10.HeaderText = "Company";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn11.HeaderText = "Company";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dgvNotPaidInvoices
            // 
            this.dgvNotPaidInvoices.AllowUserToAddRows = false;
            this.dgvNotPaidInvoices.AllowUserToDeleteRows = false;
            this.dgvNotPaidInvoices.AutoGenerateColumns = false;
            this.dgvNotPaidInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotPaidInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotPaidInvoices.ColumnHeadersVisible = false;
            this.dgvNotPaidInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn20});
            this.dgvNotPaidInvoices.DataSource = this.customInvoiceBindingSource;
            this.dgvNotPaidInvoices.Location = new System.Drawing.Point(474, 105);
            this.dgvNotPaidInvoices.Name = "dgvNotPaidInvoices";
            this.dgvNotPaidInvoices.ReadOnly = true;
            this.dgvNotPaidInvoices.RowHeadersWidth = 51;
            this.dgvNotPaidInvoices.RowTemplate.Height = 24;
            this.dgvNotPaidInvoices.Size = new System.Drawing.Size(297, 364);
            this.dgvNotPaidInvoices.TabIndex = 5;
            this.dgvNotPaidInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotPaidInvoices_CellClick);
            // 
            // customInvoiceBindingSource
            // 
            this.customInvoiceBindingSource.DataSource = typeof(Barroc_Intens.CustomInvoice);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn3.HeaderText = "Company";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "PaymentTerm";
            this.dataGridViewTextBoxColumn20.HeaderText = "PaymentTerm";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn1
            // 
            this.companyDataGridViewTextBoxColumn1.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn1.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn1.Name = "companyDataGridViewTextBoxColumn1";
            this.companyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // paidAtDataGridViewTextBoxColumn1
            // 
            this.paidAtDataGridViewTextBoxColumn1.DataPropertyName = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn1.HeaderText = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.paidAtDataGridViewTextBoxColumn1.Name = "paidAtDataGridViewTextBoxColumn1";
            this.paidAtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paidAtDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PaymentTerm";
            this.dataGridViewTextBoxColumn13.HeaderText = "PaymentTerm";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // InvoiceOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.dgvNotPaidInvoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPaidInvoices);
            this.Controls.Add(this.dgvPaidInvoices);
            this.Controls.Add(this.btnBackToFinanceDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceOverviewForm";
            this.Text = "InvoiceOverviewForm";
            this.Load += new System.EventHandler(this.InvoiceOverviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaidInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToFinanceDashboard;
        private System.Windows.Forms.DataGridView dgvPaidInvoices;
        private System.Windows.Forms.BindingSource customInvoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblPaidInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dgvNotPaidInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}