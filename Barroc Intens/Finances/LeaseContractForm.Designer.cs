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
            this.dgvCompanys = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDirectToFinanceDash = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkrCheckedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanys)).BeginInit();
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
            // dgvCompanys
            // 
            this.dgvCompanys.AutoGenerateColumns = false;
            this.dgvCompanys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.bkrCheckedAtDataGridViewTextBoxColumn,
            this.User});
            this.dgvCompanys.DataSource = this.companyBindingSource;
            this.dgvCompanys.Location = new System.Drawing.Point(413, 60);
            this.dgvCompanys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompanys.Name = "dgvCompanys";
            this.dgvCompanys.RowHeadersVisible = false;
            this.dgvCompanys.RowHeadersWidth = 51;
            this.dgvCompanys.RowTemplate.Height = 24;
            this.dgvCompanys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanys.Size = new System.Drawing.Size(479, 386);
            this.dgvCompanys.TabIndex = 6;
            this.dgvCompanys.SelectionChanged += new System.EventHandler(this.dgvCompanys_SelectionChanged);
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
            this.btnDirectToFinanceDash.Location = new System.Drawing.Point(713, 10);
            this.btnDirectToFinanceDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirectToFinanceDash.Name = "btnDirectToFinanceDash";
            this.btnDirectToFinanceDash.Size = new System.Drawing.Size(179, 46);
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
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // LeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnDirectToFinanceDash);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCompanys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBkrPositive);
            this.Controls.Add(this.lblBkrCheckResult);
            this.Controls.Add(this.cbBkrNegative);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LeaseContractForm";
            this.Text = "Leasecontracten";
            this.Load += new System.EventHandler(this.LeaseContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanys)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCompanys;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDirectToFinanceDash;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkrCheckedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}