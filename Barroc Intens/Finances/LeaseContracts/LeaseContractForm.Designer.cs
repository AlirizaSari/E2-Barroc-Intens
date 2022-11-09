namespace Barroc_Intens.Finances
{
    partial class LeaseContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaseContractForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btnDirectToFinanceDash = new System.Windows.Forms.Button();
            this.btnCreateLeaseContract = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEditLeaseContract = new System.Windows.Forms.Button();
            this.dgvLeaseContracts = new System.Windows.Forms.DataGridView();
            this.btnDeleteLeaseContract = new System.Windows.Forms.Button();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leasecontractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaseContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leasecontractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leasecontracten";
            // 
            // btnDirectToFinanceDash
            // 
            this.btnDirectToFinanceDash.Location = new System.Drawing.Point(1008, 11);
            this.btnDirectToFinanceDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirectToFinanceDash.Name = "btnDirectToFinanceDash";
            this.btnDirectToFinanceDash.Size = new System.Drawing.Size(179, 46);
            this.btnDirectToFinanceDash.TabIndex = 25;
            this.btnDirectToFinanceDash.Text = "Terug naar finances dashboard";
            this.btnDirectToFinanceDash.UseVisualStyleBackColor = true;
            this.btnDirectToFinanceDash.Click += new System.EventHandler(this.btnDirectToFinanceDash_Click);
            // 
            // btnCreateLeaseContract
            // 
            this.btnCreateLeaseContract.Location = new System.Drawing.Point(941, 261);
            this.btnCreateLeaseContract.Name = "btnCreateLeaseContract";
            this.btnCreateLeaseContract.Size = new System.Drawing.Size(173, 44);
            this.btnCreateLeaseContract.TabIndex = 26;
            this.btnCreateLeaseContract.Text = "Creëer leasecontract";
            this.btnCreateLeaseContract.UseVisualStyleBackColor = true;
            this.btnCreateLeaseContract.Click += new System.EventHandler(this.btnCreateLeaseContract_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 421);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 27;
            // 
            // btnEditLeaseContract
            // 
            this.btnEditLeaseContract.Location = new System.Drawing.Point(941, 311);
            this.btnEditLeaseContract.Name = "btnEditLeaseContract";
            this.btnEditLeaseContract.Size = new System.Drawing.Size(173, 44);
            this.btnEditLeaseContract.TabIndex = 28;
            this.btnEditLeaseContract.Text = "Bewerken";
            this.btnEditLeaseContract.UseVisualStyleBackColor = true;
            this.btnEditLeaseContract.Click += new System.EventHandler(this.btnEditLeaseContract_Click);
            // 
            // dgvLeaseContracts
            // 
            this.dgvLeaseContracts.AutoGenerateColumns = false;
            this.dgvLeaseContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLeaseContracts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLeaseContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaseContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.paymentTermDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.dgvLeaseContracts.DataSource = this.leasecontractBindingSource;
            this.dgvLeaseContracts.Location = new System.Drawing.Point(18, 79);
            this.dgvLeaseContracts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLeaseContracts.Name = "dgvLeaseContracts";
            this.dgvLeaseContracts.RowHeadersVisible = false;
            this.dgvLeaseContracts.RowHeadersWidth = 51;
            this.dgvLeaseContracts.RowTemplate.Height = 24;
            this.dgvLeaseContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaseContracts.Size = new System.Drawing.Size(858, 386);
            this.dgvLeaseContracts.TabIndex = 29;
            this.dgvLeaseContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaseContracts_CellClick);
            // 
            // btnDeleteLeaseContract
            // 
            this.btnDeleteLeaseContract.Location = new System.Drawing.Point(941, 361);
            this.btnDeleteLeaseContract.Name = "btnDeleteLeaseContract";
            this.btnDeleteLeaseContract.Size = new System.Drawing.Size(173, 44);
            this.btnDeleteLeaseContract.TabIndex = 30;
            this.btnDeleteLeaseContract.Text = "Verwijder";
            this.btnDeleteLeaseContract.UseVisualStyleBackColor = true;
            this.btnDeleteLeaseContract.Click += new System.EventHandler(this.btnDeleteLeaseContract_Click);
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Width = 74;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.createDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Width = 75;
            // 
            // paymentTermDataGridViewTextBoxColumn
            // 
            this.paymentTermDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.HeaderText = "Betaaltermijn";
            this.paymentTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentTermDataGridViewTextBoxColumn.Name = "paymentTermDataGridViewTextBoxColumn";
            this.paymentTermDataGridViewTextBoxColumn.Width = 114;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Koffiezetapparaat";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.Width = 141;
            // 
            // leasecontractBindingSource
            // 
            this.leasecontractBindingSource.DataSource = typeof(Barroc_Intens.Classes.Leasecontract);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // LeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 637);
            this.Controls.Add(this.btnDeleteLeaseContract);
            this.Controls.Add(this.dgvLeaseContracts);
            this.Controls.Add(this.btnEditLeaseContract);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCreateLeaseContract);
            this.Controls.Add(this.btnDirectToFinanceDash);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LeaseContractForm";
            this.Text = "Leasecontracten";
            this.Load += new System.EventHandler(this.LeaseContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaseContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leasecontractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDirectToFinanceDash;
        private System.Windows.Forms.Button btnCreateLeaseContract;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEditLeaseContract;
        private System.Windows.Forms.BindingSource leasecontractBindingSource;
        private System.Windows.Forms.DataGridView dgvLeaseContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteLeaseContract;
    }
}