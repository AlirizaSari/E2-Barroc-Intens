namespace Barroc_Intens.Finances.LeaseContracts
{
    partial class EditLeaseContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLeaseContractForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cboxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditLeaseContract = new System.Windows.Forms.Button();
            this.cboxProducts = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.cbMonthly = new System.Windows.Forms.CheckBox();
            this.cbYearly = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(69, 145);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(86, 16);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Bedrijfsnaam";
            // 
            // cboxCompany
            // 
            this.cboxCompany.DataSource = this.companyBindingSource;
            this.cboxCompany.DisplayMember = "Name";
            this.cboxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCompany.FormattingEnabled = true;
            this.cboxCompany.Location = new System.Drawing.Point(190, 142);
            this.cboxCompany.Name = "cboxCompany";
            this.cboxCompany.Size = new System.Drawing.Size(209, 24);
            this.cboxCompany.TabIndex = 2;
            this.cboxCompany.ValueMember = "CompanyId";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // btnEditLeaseContract
            // 
            this.btnEditLeaseContract.Location = new System.Drawing.Point(442, 197);
            this.btnEditLeaseContract.Name = "btnEditLeaseContract";
            this.btnEditLeaseContract.Size = new System.Drawing.Size(138, 51);
            this.btnEditLeaseContract.TabIndex = 4;
            this.btnEditLeaseContract.Text = "Bewerk leasecontract";
            this.btnEditLeaseContract.UseVisualStyleBackColor = true;
            this.btnEditLeaseContract.Click += new System.EventHandler(this.btnEditLeaseContract_Click);
            // 
            // cboxProducts
            // 
            this.cboxProducts.DataSource = this.productBindingSource;
            this.cboxProducts.DisplayMember = "Name";
            this.cboxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProducts.FormattingEnabled = true;
            this.cboxProducts.Location = new System.Drawing.Point(191, 172);
            this.cboxProducts.Name = "cboxProducts";
            this.cboxProducts.Size = new System.Drawing.Size(208, 24);
            this.cboxProducts.TabIndex = 5;
            this.cboxProducts.ValueMember = "ProductId";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Barroc_Intens.Product);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Koffiezetapparaat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Location = new System.Drawing.Point(191, 202);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(208, 22);
            this.dtpCreateDate.TabIndex = 13;
            // 
            // cbMonthly
            // 
            this.cbMonthly.AutoSize = true;
            this.cbMonthly.Location = new System.Drawing.Point(192, 232);
            this.cbMonthly.Name = "cbMonthly";
            this.cbMonthly.Size = new System.Drawing.Size(102, 20);
            this.cbMonthly.TabIndex = 14;
            this.cbMonthly.Text = "Maandelijks";
            this.cbMonthly.UseVisualStyleBackColor = true;
            // 
            // cbYearly
            // 
            this.cbYearly.AutoSize = true;
            this.cbYearly.Location = new System.Drawing.Point(312, 232);
            this.cbYearly.Name = "cbYearly";
            this.cbYearly.Size = new System.Drawing.Size(79, 20);
            this.cbYearly.TabIndex = 20;
            this.cbYearly.Text = "Jaarlijks";
            this.cbYearly.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Betaaltermijn";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(66, 421);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 24;
            // 
            // EditLeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 342);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYearly);
            this.Controls.Add(this.cbMonthly);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxProducts);
            this.Controls.Add(this.btnEditLeaseContract);
            this.Controls.Add(this.cboxCompany);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditLeaseContractForm";
            this.Text = "Bewerk leasecontract";
            this.Load += new System.EventHandler(this.EditLeaseContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ComboBox cboxCompany;
        private System.Windows.Forms.Button btnEditLeaseContract;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ComboBox cboxProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.CheckBox cbMonthly;
        private System.Windows.Forms.CheckBox cbYearly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
    }
}