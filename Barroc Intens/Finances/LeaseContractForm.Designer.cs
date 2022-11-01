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
            this.chbBkrCheckNegative = new System.Windows.Forms.CheckBox();
            this.lblBkrCheckResult = new System.Windows.Forms.Label();
            this.chbBkrCheckPositive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompanys = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDirectToFinanceDash = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkrCheckedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chbBkrCheckNegative
            // 
            this.chbBkrCheckNegative.AutoSize = true;
            this.chbBkrCheckNegative.Location = new System.Drawing.Point(224, 64);
            this.chbBkrCheckNegative.Margin = new System.Windows.Forms.Padding(2);
            this.chbBkrCheckNegative.Name = "chbBkrCheckNegative";
            this.chbBkrCheckNegative.Size = new System.Drawing.Size(66, 17);
            this.chbBkrCheckNegative.TabIndex = 0;
            this.chbBkrCheckNegative.Text = "Negatief";
            this.chbBkrCheckNegative.UseVisualStyleBackColor = true;
            // 
            // lblBkrCheckResult
            // 
            this.lblBkrCheckResult.AutoSize = true;
            this.lblBkrCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBkrCheckResult.Location = new System.Drawing.Point(16, 49);
            this.lblBkrCheckResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBkrCheckResult.Name = "lblBkrCheckResult";
            this.lblBkrCheckResult.Size = new System.Drawing.Size(112, 34);
            this.lblBkrCheckResult.TabIndex = 1;
            this.lblBkrCheckResult.Text = "Bkr-Check:\r\nnegatief/positief:";
            // 
            // chbBkrCheckPositive
            // 
            this.chbBkrCheckPositive.AutoSize = true;
            this.chbBkrCheckPositive.Location = new System.Drawing.Point(131, 64);
            this.chbBkrCheckPositive.Margin = new System.Windows.Forms.Padding(2);
            this.chbBkrCheckPositive.Name = "chbBkrCheckPositive";
            this.chbBkrCheckPositive.Size = new System.Drawing.Size(60, 17);
            this.chbBkrCheckPositive.TabIndex = 2;
            this.chbBkrCheckPositive.Text = "Positief";
            this.chbBkrCheckPositive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "lease contract opstellen";
            // 
            // dgvCompanys
            // 
            this.dgvCompanys.AutoGenerateColumns = false;
            this.dgvCompanys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.bkrCheckedAtDataGridViewTextBoxColumn,
            this.User});
            this.dgvCompanys.DataSource = this.companyBindingSource;
            this.dgvCompanys.Location = new System.Drawing.Point(310, 49);
            this.dgvCompanys.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompanys.Name = "dgvCompanys";
            this.dgvCompanys.RowHeadersVisible = false;
            this.dgvCompanys.RowHeadersWidth = 51;
            this.dgvCompanys.RowTemplate.Height = 24;
            this.dgvCompanys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanys.Size = new System.Drawing.Size(359, 314);
            this.dgvCompanys.TabIndex = 6;
            this.dgvCompanys.SelectionChanged += new System.EventHandler(this.dgvCompanys_SelectionChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 314);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "test save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDirectToFinanceDash
            // 
            this.btnDirectToFinanceDash.Location = new System.Drawing.Point(535, 8);
            this.btnDirectToFinanceDash.Margin = new System.Windows.Forms.Padding(2);
            this.btnDirectToFinanceDash.Name = "btnDirectToFinanceDash";
            this.btnDirectToFinanceDash.Size = new System.Drawing.Size(134, 37);
            this.btnDirectToFinanceDash.TabIndex = 25;
            this.btnDirectToFinanceDash.Text = "Terug naar finances dashboard";
            this.btnDirectToFinanceDash.UseVisualStyleBackColor = true;
            this.btnDirectToFinanceDash.Click += new System.EventHandler(this.btnDirectToFinanceDash_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bkrCheckedAtDataGridViewTextBoxColumn
            // 
            this.bkrCheckedAtDataGridViewTextBoxColumn.DataPropertyName = "BkrCheckedAt";
            this.bkrCheckedAtDataGridViewTextBoxColumn.HeaderText = "BkrCheckedAt";
            this.bkrCheckedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bkrCheckedAtDataGridViewTextBoxColumn.Name = "bkrCheckedAtDataGridViewTextBoxColumn";
            this.bkrCheckedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.bkrCheckedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            // 
            // LeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 366);
            this.Controls.Add(this.btnDirectToFinanceDash);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCompanys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbBkrCheckPositive);
            this.Controls.Add(this.lblBkrCheckResult);
            this.Controls.Add(this.chbBkrCheckNegative);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LeaseContractForm";
            this.Text = "Leasecontracten";
            this.Load += new System.EventHandler(this.LeaseContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbBkrCheckNegative;
        private System.Windows.Forms.Label lblBkrCheckResult;
        private System.Windows.Forms.CheckBox chbBkrCheckPositive;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompanys;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDirectToFinanceDash;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkrCheckedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}