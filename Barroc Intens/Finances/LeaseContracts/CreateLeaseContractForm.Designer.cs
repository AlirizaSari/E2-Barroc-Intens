﻿namespace Barroc_Intens.Finances.LeaseContracts
{
    partial class CreateLeaseContractForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cboxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.btnCreateLeaseContract = new System.Windows.Forms.Button();
            this.cboxProducts = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.cbMonthly = new System.Windows.Forms.CheckBox();
            this.txbTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbHouseNumber = new System.Windows.Forms.TextBox();
            this.cbYearly = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(67, 145);
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
            this.cboxCompany.Size = new System.Drawing.Size(200, 24);
            this.cboxCompany.TabIndex = 2;
            this.cboxCompany.ValueMember = "CompanyId";
            this.cboxCompany.SelectedIndexChanged += new System.EventHandler(this.cboxCompany_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // txbStreet
            // 
            this.txbStreet.Location = new System.Drawing.Point(190, 201);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(200, 22);
            this.txbStreet.TabIndex = 3;
            // 
            // btnCreateLeaseContract
            // 
            this.btnCreateLeaseContract.Location = new System.Drawing.Point(606, 260);
            this.btnCreateLeaseContract.Name = "btnCreateLeaseContract";
            this.btnCreateLeaseContract.Size = new System.Drawing.Size(138, 51);
            this.btnCreateLeaseContract.TabIndex = 4;
            this.btnCreateLeaseContract.Text = "Creëer leasecontract";
            this.btnCreateLeaseContract.UseVisualStyleBackColor = true;
            this.btnCreateLeaseContract.Click += new System.EventHandler(this.btnCreateLeaseContract_Click);
            // 
            // cboxProducts
            // 
            this.cboxProducts.DataSource = this.productBindingSource;
            this.cboxProducts.DisplayMember = "Name";
            this.cboxProducts.FormattingEnabled = true;
            this.cboxProducts.Location = new System.Drawing.Point(544, 138);
            this.cboxProducts.Name = "cboxProducts";
            this.cboxProducts.Size = new System.Drawing.Size(200, 24);
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
            this.label1.Location = new System.Drawing.Point(421, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Koffiezetapparaat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefoon";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(67, 204);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(42, 16);
            this.lblCompanyAddress.TabIndex = 12;
            this.lblCompanyAddress.Text = "Straat";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Location = new System.Drawing.Point(544, 168);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCreateDate.TabIndex = 13;
            // 
            // cbMonthly
            // 
            this.cbMonthly.AutoSize = true;
            this.cbMonthly.Location = new System.Drawing.Point(191, 285);
            this.cbMonthly.Name = "cbMonthly";
            this.cbMonthly.Size = new System.Drawing.Size(102, 20);
            this.cbMonthly.TabIndex = 14;
            this.cbMonthly.Text = "Maandelijks";
            this.cbMonthly.UseVisualStyleBackColor = true;
            // 
            // txbTelephoneNumber
            // 
            this.txbTelephoneNumber.Location = new System.Drawing.Point(191, 257);
            this.txbTelephoneNumber.Name = "txbTelephoneNumber";
            this.txbTelephoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txbTelephoneNumber.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stad";
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(190, 173);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(200, 22);
            this.txbCity.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Huisnummer";
            // 
            // txbHouseNumber
            // 
            this.txbHouseNumber.Location = new System.Drawing.Point(191, 229);
            this.txbHouseNumber.Name = "txbHouseNumber";
            this.txbHouseNumber.Size = new System.Drawing.Size(200, 22);
            this.txbHouseNumber.TabIndex = 18;
            // 
            // cbYearly
            // 
            this.cbYearly.AutoSize = true;
            this.cbYearly.Location = new System.Drawing.Point(311, 285);
            this.cbYearly.Name = "cbYearly";
            this.cbYearly.Size = new System.Drawing.Size(79, 20);
            this.cbYearly.TabIndex = 20;
            this.cbYearly.Text = "Jaarlijks";
            this.cbYearly.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Betaaltermijn";
            // 
            // CreateLeaseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYearly);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbHouseNumber);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbTelephoneNumber);
            this.Controls.Add(this.cbMonthly);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxProducts);
            this.Controls.Add(this.btnCreateLeaseContract);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.cboxCompany);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateLeaseContractForm";
            this.Text = "Creëer leasecontract";
            this.Load += new System.EventHandler(this.CreateInvoiceForm_Load);
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
        private System.Windows.Forms.TextBox txbStreet;
        private System.Windows.Forms.Button btnCreateLeaseContract;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ComboBox cboxProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.CheckBox cbMonthly;
        private System.Windows.Forms.TextBox txbTelephoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbHouseNumber;
        private System.Windows.Forms.CheckBox cbYearly;
        private System.Windows.Forms.Label label3;
    }
}