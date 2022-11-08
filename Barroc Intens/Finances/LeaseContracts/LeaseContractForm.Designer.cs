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
            this.cbBkrNegative = new System.Windows.Forms.CheckBox();
            this.lblBkrCheckResult = new System.Windows.Forms.Label();
            this.cbBkrPositive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDirectToFinanceDash = new System.Windows.Forms.Button();
            this.btnCreateLeaseContract = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEditLeaseContract = new System.Windows.Forms.Button();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkrCheckedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBkrChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBkrNegative
            // 
            this.cbBkrNegative.AutoSize = true;
            this.cbBkrNegative.Location = new System.Drawing.Point(282, 79);
            this.cbBkrNegative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBkrNegative.Name = "cbBkrNegative";
            this.cbBkrNegative.Size = new System.Drawing.Size(80, 20);
            this.cbBkrNegative.TabIndex = 1;
            this.cbBkrNegative.Text = "Negatief";
            this.cbBkrNegative.UseVisualStyleBackColor = true;
            this.cbBkrNegative.Click += new System.EventHandler(this.cbBkrNegative_Click);
            // 
            // lblBkrCheckResult
            // 
            this.lblBkrCheckResult.AutoSize = true;
            this.lblBkrCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBkrCheckResult.Location = new System.Drawing.Point(21, 60);
            this.lblBkrCheckResult.Name = "lblBkrCheckResult";
            this.lblBkrCheckResult.Size = new System.Drawing.Size(132, 40);
            this.lblBkrCheckResult.TabIndex = 1;
            this.lblBkrCheckResult.Text = "Bkr-Check:\r\nnegatief/positief:";
            // 
            // cbBkrPositive
            // 
            this.cbBkrPositive.AutoSize = true;
            this.cbBkrPositive.Location = new System.Drawing.Point(175, 79);
            this.cbBkrPositive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBkrPositive.Name = "cbBkrPositive";
            this.cbBkrPositive.Size = new System.Drawing.Size(73, 20);
            this.cbBkrPositive.TabIndex = 0;
            this.cbBkrPositive.Text = "Positief";
            this.cbBkrPositive.UseVisualStyleBackColor = true;
            this.cbBkrPositive.Click += new System.EventHandler(this.cbBkrPositive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "lease contract opstellen";
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.AutoGenerateColumns = false;
            this.dgvCompanies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.bkrCheckedAtDataGridViewTextBoxColumn,
            this.IsBkrChecked});
            this.dgvCompanies.DataSource = this.companyBindingSource;
            this.dgvCompanies.Location = new System.Drawing.Point(424, 60);
            this.dgvCompanies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.RowHeadersVisible = false;
            this.dgvCompanies.RowHeadersWidth = 51;
            this.dgvCompanies.RowTemplate.Height = 24;
            this.dgvCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanies.Size = new System.Drawing.Size(378, 386);
            this.dgvCompanies.TabIndex = 6;
            this.dgvCompanies.SelectionChanged += new System.EventHandler(this.dgvCompanys_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 386);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "test save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDirectToFinanceDash
            // 
            this.btnDirectToFinanceDash.Location = new System.Drawing.Point(623, 9);
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
            this.btnCreateLeaseContract.Location = new System.Drawing.Point(117, 260);
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
            this.btnEditLeaseContract.Location = new System.Drawing.Point(120, 310);
            this.btnEditLeaseContract.Name = "btnEditLeaseContract";
            this.btnEditLeaseContract.Size = new System.Drawing.Size(170, 44);
            this.btnEditLeaseContract.TabIndex = 28;
            this.btnEditLeaseContract.Text = "Leasecontract bewerken";
            this.btnEditLeaseContract.UseVisualStyleBackColor = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bkrCheckedAtDataGridViewTextBoxColumn
            // 
            this.bkrCheckedAtDataGridViewTextBoxColumn.DataPropertyName = "BkrCheckedAt";
            this.bkrCheckedAtDataGridViewTextBoxColumn.HeaderText = "BKR checkdatum";
            this.bkrCheckedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bkrCheckedAtDataGridViewTextBoxColumn.Name = "bkrCheckedAtDataGridViewTextBoxColumn";
            this.bkrCheckedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.bkrCheckedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // IsBkrChecked
            // 
            this.IsBkrChecked.DataPropertyName = "IsBkrChecked";
            this.IsBkrChecked.HeaderText = "BKR-check";
            this.IsBkrChecked.MinimumWidth = 6;
            this.IsBkrChecked.Name = "IsBkrChecked";
            this.IsBkrChecked.Width = 125;
            // 
            // LeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btnEditLeaseContract);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCreateLeaseContract);
            this.Controls.Add(this.btnDirectToFinanceDash);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCompanies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBkrPositive);
            this.Controls.Add(this.lblBkrCheckResult);
            this.Controls.Add(this.cbBkrNegative);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LeaseContractForm";
            this.Text = "Leasecontracten";
            this.Load += new System.EventHandler(this.LeaseContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbBkrNegative;
        private System.Windows.Forms.Label lblBkrCheckResult;
        private System.Windows.Forms.CheckBox cbBkrPositive;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompanies;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDirectToFinanceDash;
        private System.Windows.Forms.Button btnCreateLeaseContract;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEditLeaseContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkrCheckedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsBkrChecked;
    }
}