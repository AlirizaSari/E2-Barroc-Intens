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
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.bkrCheckedAtDataGridViewTextBoxColumn1,
            this.userIdDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dgvCompanysAviableForBkrCheck.DataSource = this.companyBindingSource;
            this.dgvCompanysAviableForBkrCheck.Location = new System.Drawing.Point(431, 46);
            this.dgvCompanysAviableForBkrCheck.Name = "dgvCompanysAviableForBkrCheck";
            this.dgvCompanysAviableForBkrCheck.RowHeadersWidth = 51;
            this.dgvCompanysAviableForBkrCheck.RowTemplate.Height = 24;
            // 
            this.lblCompanyListHeader.AutoSize = true;
            this.lblCompanyListHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyListHeader.Location = new System.Drawing.Point(482, 9);
            this.lblCompanyListHeader.Name = "lblCompanyListHeader";
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // companyIdDataGridViewTextBoxColumn
            this.companyIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // houseNumberDataGridViewTextBoxColumn
            // 
            this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.HeaderText = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
            this.houseNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            this.countryCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bkrCheckedAtDataGridViewTextBoxColumn1
            // 
            this.bkrCheckedAtDataGridViewTextBoxColumn1.DataPropertyName = "BkrCheckedAt";
            this.bkrCheckedAtDataGridViewTextBoxColumn1.HeaderText = "BkrCheckedAt";
            this.bkrCheckedAtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bkrCheckedAtDataGridViewTextBoxColumn1.Name = "bkrCheckedAtDataGridViewTextBoxColumn1";
            this.bkrCheckedAtDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 125;
            // 
            // LeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCompanyListHeader);
            this.Controls.Add(this.dgvCompanysAviableForBkrCheck);
            this.Controls.Add(this.chbBkrNegative);
            this.Controls.Add(this.lblCompanyToCheck);
            this.Controls.Add(this.lblHeaderInputBkr);
            this.Controls.Add(this.comboBoxNameCompany);
            this.Controls.Add(this.chbBkrPositive);
            this.Name = "LeaseContractForm";
            this.Text = "LeaseContractForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyBkr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanysAviableForBkrCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbBkrPositive;
        private System.Windows.Forms.ComboBox comboBoxNameCompany;
        private System.Windows.Forms.DataGridView dgvCompanyBkr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
#pragma warning disable CS0108 // 'LeaseContractForm.Name' hides inherited member 'Control.Name'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
#pragma warning restore CS0108 // 'LeaseContractForm.Name' hides inherited member 'Control.Name'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.DataGridViewTextBoxColumn bkrCheckedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblHeaderInputBkr;
        private System.Windows.Forms.Label lblCompanyToCheck;
        private System.Windows.Forms.CheckBox chbBkrNegative;
        private System.Windows.Forms.DataGridView dgvCompanysAviableForBkrCheck;
        private System.Windows.Forms.Label lblCompanyListHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkrCheckedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}