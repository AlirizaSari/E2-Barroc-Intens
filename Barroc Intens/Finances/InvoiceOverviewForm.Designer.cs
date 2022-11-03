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
            this.btnBackToFinanceDashboard = new System.Windows.Forms.Button();
            this.dgvPaidInvoices = new System.Windows.Forms.DataGridView();
            this.customInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursWorkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customInvoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customInvoiceProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customInvoiceProductIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customInvoiceIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceProductsBindingSource)).BeginInit();
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
            this.customInvoiceIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paidAtDataGridViewTextBoxColumn,
            this.companyIdDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.companyEmailDataGridViewTextBoxColumn,
            this.companyAdressDataGridViewTextBoxColumn,
            this.hoursWorkedDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.pricePerHourDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvPaidInvoices.DataSource = this.customInvoiceBindingSource;
            this.dgvPaidInvoices.Location = new System.Drawing.Point(41, 74);
            this.dgvPaidInvoices.Name = "dgvPaidInvoices";
            this.dgvPaidInvoices.ReadOnly = true;
            this.dgvPaidInvoices.RowHeadersWidth = 51;
            this.dgvPaidInvoices.RowTemplate.Height = 24;
            this.dgvPaidInvoices.Size = new System.Drawing.Size(297, 364);
            this.dgvPaidInvoices.TabIndex = 1;
            // 
            // customInvoiceBindingSource
            // 
            this.customInvoiceBindingSource.DataSource = typeof(Barroc_Intens.CustomInvoice);
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerHourDataGridViewTextBoxColumn
            // 
            this.pricePerHourDataGridViewTextBoxColumn.DataPropertyName = "PricePerHour";
            this.pricePerHourDataGridViewTextBoxColumn.HeaderText = "PricePerHour";
            this.pricePerHourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerHourDataGridViewTextBoxColumn.Name = "pricePerHourDataGridViewTextBoxColumn";
            this.pricePerHourDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoursWorkedDataGridViewTextBoxColumn
            // 
            this.hoursWorkedDataGridViewTextBoxColumn.DataPropertyName = "HoursWorked";
            this.hoursWorkedDataGridViewTextBoxColumn.HeaderText = "HoursWorked";
            this.hoursWorkedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursWorkedDataGridViewTextBoxColumn.Name = "hoursWorkedDataGridViewTextBoxColumn";
            this.hoursWorkedDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursWorkedDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyAdressDataGridViewTextBoxColumn
            // 
            this.companyAdressDataGridViewTextBoxColumn.DataPropertyName = "CompanyAdress";
            this.companyAdressDataGridViewTextBoxColumn.HeaderText = "CompanyAdress";
            this.companyAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyAdressDataGridViewTextBoxColumn.Name = "companyAdressDataGridViewTextBoxColumn";
            this.companyAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyEmailDataGridViewTextBoxColumn
            // 
            this.companyEmailDataGridViewTextBoxColumn.DataPropertyName = "CompanyEmail";
            this.companyEmailDataGridViewTextBoxColumn.HeaderText = "CompanyEmail";
            this.companyEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyEmailDataGridViewTextBoxColumn.Name = "companyEmailDataGridViewTextBoxColumn";
            this.companyEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyIdDataGridViewTextBoxColumn
            // 
            this.companyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.HeaderText = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // paidAtDataGridViewTextBoxColumn
            // 
            this.paidAtDataGridViewTextBoxColumn.DataPropertyName = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn.HeaderText = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidAtDataGridViewTextBoxColumn.Name = "paidAtDataGridViewTextBoxColumn";
            this.paidAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // customInvoiceIdDataGridViewTextBoxColumn
            // 
            this.customInvoiceIdDataGridViewTextBoxColumn.DataPropertyName = "CustomInvoiceId";
            this.customInvoiceIdDataGridViewTextBoxColumn.HeaderText = "CustomInvoiceId";
            this.customInvoiceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customInvoiceIdDataGridViewTextBoxColumn.Name = "customInvoiceIdDataGridViewTextBoxColumn";
            this.customInvoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customInvoiceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customInvoiceProductIdDataGridViewTextBoxColumn,
            this.customInvoiceIdDataGridViewTextBoxColumn1,
            this.customInvoiceDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.pricePerProductDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customInvoiceProductsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(474, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(297, 364);
            this.dataGridView1.TabIndex = 2;
            // 
            // customInvoiceProductsBindingSource
            // 
            this.customInvoiceProductsBindingSource.DataMember = "CustomInvoiceProducts";
            this.customInvoiceProductsBindingSource.DataSource = this.customInvoiceBindingSource;
            // 
            // customInvoiceProductIdDataGridViewTextBoxColumn
            // 
            this.customInvoiceProductIdDataGridViewTextBoxColumn.DataPropertyName = "CustomInvoiceProductId";
            this.customInvoiceProductIdDataGridViewTextBoxColumn.HeaderText = "CustomInvoiceProductId";
            this.customInvoiceProductIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customInvoiceProductIdDataGridViewTextBoxColumn.Name = "customInvoiceProductIdDataGridViewTextBoxColumn";
            this.customInvoiceProductIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customInvoiceProductIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customInvoiceIdDataGridViewTextBoxColumn1
            // 
            this.customInvoiceIdDataGridViewTextBoxColumn1.DataPropertyName = "CustomInvoiceId";
            this.customInvoiceIdDataGridViewTextBoxColumn1.HeaderText = "CustomInvoiceId";
            this.customInvoiceIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customInvoiceIdDataGridViewTextBoxColumn1.Name = "customInvoiceIdDataGridViewTextBoxColumn1";
            this.customInvoiceIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.customInvoiceIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customInvoiceDataGridViewTextBoxColumn
            // 
            this.customInvoiceDataGridViewTextBoxColumn.DataPropertyName = "CustomInvoice";
            this.customInvoiceDataGridViewTextBoxColumn.HeaderText = "CustomInvoice";
            this.customInvoiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customInvoiceDataGridViewTextBoxColumn.Name = "customInvoiceDataGridViewTextBoxColumn";
            this.customInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.customInvoiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerProductDataGridViewTextBoxColumn
            // 
            this.pricePerProductDataGridViewTextBoxColumn.DataPropertyName = "PricePerProduct";
            this.pricePerProductDataGridViewTextBoxColumn.HeaderText = "PricePerProduct";
            this.pricePerProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerProductDataGridViewTextBoxColumn.Name = "pricePerProductDataGridViewTextBoxColumn";
            this.pricePerProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // InvoiceOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvPaidInvoices);
            this.Controls.Add(this.btnBackToFinanceDashboard);
            this.Name = "InvoiceOverviewForm";
            this.Text = "InvoiceOverviewForm";
            this.Load += new System.EventHandler(this.InvoiceOverviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToFinanceDashboard;
        private System.Windows.Forms.DataGridView dgvPaidInvoices;
        private System.Windows.Forms.BindingSource customInvoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customInvoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursWorkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customInvoiceProductIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customInvoiceIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customInvoiceProductsBindingSource;
    }
}