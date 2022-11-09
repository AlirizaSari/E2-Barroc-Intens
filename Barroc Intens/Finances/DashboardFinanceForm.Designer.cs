using Barroc_Intens.Classes;

namespace Barroc_Intens
{
    partial class DashboardFinanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardFinanceForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.txbExtraInfo = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnDirectToInvoiceOverview = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnDirectToLeaseContract = new System.Windows.Forms.Button();
            this.btnDirectToInvoice = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.btnPaidInvoice = new System.Windows.Forms.Button();
            this.customInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursWorkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlLeft.Controls.Add(this.lblExtraInfo);
            this.pnlLeft.Controls.Add(this.txbExtraInfo);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.lblDepartment);
            this.pnlLeft.Controls.Add(this.lblAccountName);
            this.pnlLeft.Controls.Add(this.pboxLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(222, 600);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblExtraInfo
            // 
            this.lblExtraInfo.AutoSize = true;
            this.lblExtraInfo.Location = new System.Drawing.Point(20, 322);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(115, 20);
            this.lblExtraInfo.TabIndex = 6;
            this.lblExtraInfo.Text = "Extra Informatie";
            // 
            // txbExtraInfo
            // 
            this.txbExtraInfo.Enabled = false;
            this.txbExtraInfo.Location = new System.Drawing.Point(24, 345);
            this.txbExtraInfo.Multiline = true;
            this.txbExtraInfo.Name = "txbExtraInfo";
            this.txbExtraInfo.ReadOnly = true;
            this.txbExtraInfo.Size = new System.Drawing.Size(162, 160);
            this.txbExtraInfo.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(24, 525);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(53, 249);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(66, 20);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Afdeling";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(53, 220);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(107, 20);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Account Naam";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(61, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            this.pboxLogo.Click += new System.EventHandler(this.pboxLogo_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.btnDirectToInvoiceOverview);
            this.pnlTop.Controls.Add(this.lblSystemName);
            this.pnlTop.Controls.Add(this.btnDirectToLeaseContract);
            this.pnlTop.Controls.Add(this.btnDirectToInvoice);
            this.pnlTop.Controls.Add(this.btnBackToMain);
            this.pnlTop.Location = new System.Drawing.Point(222, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(903, 157);
            this.pnlTop.TabIndex = 1;
            // 
            // btnDirectToInvoiceOverview
            // 
            this.btnDirectToInvoiceOverview.Location = new System.Drawing.Point(496, 117);
            this.btnDirectToInvoiceOverview.Name = "btnDirectToInvoiceOverview";
            this.btnDirectToInvoiceOverview.Size = new System.Drawing.Size(172, 37);
            this.btnDirectToInvoiceOverview.TabIndex = 4;
            this.btnDirectToInvoiceOverview.Text = "Betaal overzicht";
            this.btnDirectToInvoiceOverview.UseVisualStyleBackColor = true;
            this.btnDirectToInvoiceOverview.Click += new System.EventHandler(this.btnDirectToInvoiceOverview_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(417, 24);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(138, 41);
            this.lblSystemName.TabIndex = 3;
            this.lblSystemName.Text = "Finances";
            // 
            // btnDirectToLeaseContract
            // 
            this.btnDirectToLeaseContract.Location = new System.Drawing.Point(716, 117);
            this.btnDirectToLeaseContract.Name = "btnDirectToLeaseContract";
            this.btnDirectToLeaseContract.Size = new System.Drawing.Size(172, 37);
            this.btnDirectToLeaseContract.TabIndex = 2;
            this.btnDirectToLeaseContract.Text = "Leasecontracten";
            this.btnDirectToLeaseContract.UseVisualStyleBackColor = true;
            this.btnDirectToLeaseContract.Click += new System.EventHandler(this.btnDirectToLeaseContract_Click);
            // 
            // btnDirectToInvoice
            // 
            this.btnDirectToInvoice.Location = new System.Drawing.Point(279, 117);
            this.btnDirectToInvoice.Name = "btnDirectToInvoice";
            this.btnDirectToInvoice.Size = new System.Drawing.Size(172, 37);
            this.btnDirectToInvoice.TabIndex = 1;
            this.btnDirectToInvoice.Text = "Factuur aanmaken";
            this.btnDirectToInvoice.UseVisualStyleBackColor = true;
            this.btnDirectToInvoice.Click += new System.EventHandler(this.btnDirectToInvoice_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(46, 117);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(172, 37);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Home";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paidAtDataGridViewTextBoxColumn,
            this.companyEmailDataGridViewTextBoxColumn,
            this.companyAdressDataGridViewTextBoxColumn,
            this.hoursWorkedDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvInvoices.DataSource = this.customInvoiceBindingSource;
            this.dgvInvoices.Location = new System.Drawing.Point(228, 175);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.RowTemplate.Height = 24;
            this.dgvInvoices.Size = new System.Drawing.Size(882, 182);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);
            // 
            // btnPaidInvoice
            // 
            this.btnPaidInvoice.Location = new System.Drawing.Point(297, 386);
            this.btnPaidInvoice.Name = "btnPaidInvoice";
            this.btnPaidInvoice.Size = new System.Drawing.Size(143, 59);
            this.btnPaidInvoice.TabIndex = 3;
            this.btnPaidInvoice.Text = "Betaald";
            this.btnPaidInvoice.UseVisualStyleBackColor = true;
            this.btnPaidInvoice.Click += new System.EventHandler(this.btnPaidInvoice_Click);
            // 
            // customInvoiceBindingSource
            // 
            this.customInvoiceBindingSource.DataSource = typeof(Barroc_Intens.CustomInvoice);
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Width = 82;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 83;
            // 
            // paidAtDataGridViewTextBoxColumn
            // 
            this.paidAtDataGridViewTextBoxColumn.DataPropertyName = "Datum van betaling";
            this.paidAtDataGridViewTextBoxColumn.HeaderText = "Betaaldatum";
            this.paidAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidAtDataGridViewTextBoxColumn.Name = "paidAtDataGridViewTextBoxColumn";
            this.paidAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidAtDataGridViewTextBoxColumn.Width = 123;
            // 
            // companyEmailDataGridViewTextBoxColumn
            // 
            this.companyEmailDataGridViewTextBoxColumn.DataPropertyName = "CompanyEmail";
            this.companyEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.companyEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyEmailDataGridViewTextBoxColumn.Name = "companyEmailDataGridViewTextBoxColumn";
            this.companyEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyEmailDataGridViewTextBoxColumn.Width = 75;
            // 
            // companyAdressDataGridViewTextBoxColumn
            // 
            this.companyAdressDataGridViewTextBoxColumn.DataPropertyName = "CompanyAdress";
            this.companyAdressDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.companyAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyAdressDataGridViewTextBoxColumn.Name = "companyAdressDataGridViewTextBoxColumn";
            this.companyAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyAdressDataGridViewTextBoxColumn.Width = 76;
            // 
            // hoursWorkedDataGridViewTextBoxColumn
            // 
            this.hoursWorkedDataGridViewTextBoxColumn.DataPropertyName = "HoursWorked";
            this.hoursWorkedDataGridViewTextBoxColumn.HeaderText = "Uur gewerkt";
            this.hoursWorkedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursWorkedDataGridViewTextBoxColumn.Name = "hoursWorkedDataGridViewTextBoxColumn";
            this.hoursWorkedDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursWorkedDataGridViewTextBoxColumn.Width = 118;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notities";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 90;
            // 
            // DashboardFinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 600);
            this.Controls.Add(this.btnPaidInvoice);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardFinanceForm";
            this.Text = "Dashboard voor financiën";
            this.Load += new System.EventHandler(this.DashboardFinanceForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblExtraInfo;
        private System.Windows.Forms.TextBox txbExtraInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnDirectToLeaseContract;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnDirectToInvoice;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.BindingSource customInvoiceBindingSource;
        private System.Windows.Forms.Button btnPaidInvoice;
        private System.Windows.Forms.Button btnDirectToInvoiceOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursWorkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}