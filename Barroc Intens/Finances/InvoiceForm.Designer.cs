namespace Barroc_Intens.Finances
{
    partial class InvoiceForm
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
            this.lblInvoice = new System.Windows.Forms.Label();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAdress = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblHourlyPrice = new System.Windows.Forms.Label();
            this.txbCompanyAdress = new System.Windows.Forms.TextBox();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudHourlyPrice = new System.Windows.Forms.NumericUpDown();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmailAdresCompany = new System.Windows.Forms.TextBox();
            this.cbBkrCheck = new System.Windows.Forms.CheckBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnDirectToFinanceDash = new System.Windows.Forms.Button();
            this.cboxCompanyName = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonthly = new System.Windows.Forms.CheckBox();
            this.cbYearly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(396, 66);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(99, 27);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Factuur";
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Location = new System.Drawing.Point(606, 354);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(173, 60);
            this.btnCreateInvoice.TabIndex = 8;
            this.btnCreateInvoice.Text = "Creëer factuur";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // nudHoursWorked
            // 
            this.nudHoursWorked.DecimalPlaces = 2;
            this.nudHoursWorked.Location = new System.Drawing.Point(212, 370);
            this.nudHoursWorked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHoursWorked.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHoursWorked.Name = "nudHoursWorked";
            this.nudHoursWorked.Size = new System.Drawing.Size(218, 27);
            this.nudHoursWorked.TabIndex = 4;
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(-9, 318);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(932, 2);
            this.lblDivider.TabIndex = 4;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(60, 143);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(97, 20);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Naam Bedrijf";
            // 
            // lblCompanyAdress
            // 
            this.lblCompanyAdress.AutoSize = true;
            this.lblCompanyAdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAdress.Location = new System.Drawing.Point(60, 211);
            this.lblCompanyAdress.Name = "lblCompanyAdress";
            this.lblCompanyAdress.Size = new System.Drawing.Size(95, 20);
            this.lblCompanyAdress.TabIndex = 6;
            this.lblCompanyAdress.Text = "Bedrijfsadres";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(60, 247);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Datum";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(60, 372);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(97, 20);
            this.lblHoursWorked.TabIndex = 8;
            this.lblHoursWorked.Text = "Uren gewerkt";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(60, 408);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(58, 20);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Korting";
            // 
            // lblHourlyPrice
            // 
            this.lblHourlyPrice.AutoSize = true;
            this.lblHourlyPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyPrice.Location = new System.Drawing.Point(60, 442);
            this.lblHourlyPrice.Name = "lblHourlyPrice";
            this.lblHourlyPrice.Size = new System.Drawing.Size(87, 20);
            this.lblHourlyPrice.TabIndex = 10;
            this.lblHourlyPrice.Text = "Prijs per uur";
            // 
            // txbCompanyAdress
            // 
            this.txbCompanyAdress.Location = new System.Drawing.Point(212, 208);
            this.txbCompanyAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCompanyAdress.Name = "txbCompanyAdress";
            this.txbCompanyAdress.Size = new System.Drawing.Size(218, 27);
            this.txbCompanyAdress.TabIndex = 2;
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(212, 475);
            this.txbComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbComment.Multiline = true;
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(218, 84);
            this.txbComment.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(212, 242);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 27);
            this.dtpDate.TabIndex = 3;
            // 
            // nudDiscount
            // 
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Location = new System.Drawing.Point(212, 405);
            this.nudDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(218, 27);
            this.nudDiscount.TabIndex = 5;
            // 
            // nudHourlyPrice
            // 
            this.nudHourlyPrice.DecimalPlaces = 2;
            this.nudHourlyPrice.Location = new System.Drawing.Point(213, 440);
            this.nudHourlyPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHourlyPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHourlyPrice.Name = "nudHourlyPrice";
            this.nudHourlyPrice.Size = new System.Drawing.Size(218, 27);
            this.nudHourlyPrice.TabIndex = 6;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(60, 478);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 20);
            this.lblComment.TabIndex = 16;
            this.lblComment.Text = "Notities";
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(606, 422);
            this.btnSaveToDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(173, 60);
            this.btnSaveToDatabase.TabIndex = 9;
            this.btnSaveToDatabase.Text = "Opslaan naar database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(363, 567);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Emailadres";
            // 
            // txbEmailAdresCompany
            // 
            this.txbEmailAdresCompany.Location = new System.Drawing.Point(212, 174);
            this.txbEmailAdresCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmailAdresCompany.Name = "txbEmailAdresCompany";
            this.txbEmailAdresCompany.Size = new System.Drawing.Size(218, 27);
            this.txbEmailAdresCompany.TabIndex = 1;
            // 
            // cbBkrCheck
            // 
            this.cbBkrCheck.AutoCheck = false;
            this.cbBkrCheck.AutoSize = true;
            this.cbBkrCheck.Location = new System.Drawing.Point(606, 139);
            this.cbBkrCheck.Name = "cbBkrCheck";
            this.cbBkrCheck.Size = new System.Drawing.Size(101, 24);
            this.cbBkrCheck.TabIndex = 21;
            this.cbBkrCheck.Text = "BKR-check";
            this.cbBkrCheck.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(606, 489);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(173, 59);
            this.btnSaveToFile.TabIndex = 10;
            this.btnSaveToFile.Text = "Opslaan naar bestand";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(55, 21);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 23;
            this.pboxLogo.TabStop = false;
            this.pboxLogo.Click += new System.EventHandler(this.pboxLogo_Click);
            // 
            // btnDirectToFinanceDash
            // 
            this.btnDirectToFinanceDash.Location = new System.Drawing.Point(606, 56);
            this.btnDirectToFinanceDash.Name = "btnDirectToFinanceDash";
            this.btnDirectToFinanceDash.Size = new System.Drawing.Size(179, 52);
            this.btnDirectToFinanceDash.TabIndex = 24;
            this.btnDirectToFinanceDash.Text = "Terug naar finances dashboard";
            this.btnDirectToFinanceDash.UseVisualStyleBackColor = true;
            this.btnDirectToFinanceDash.Click += new System.EventHandler(this.btnDirectToFinanceDash_Click);
            // 
            // cboxCompanyName
            // 
            this.cboxCompanyName.DataSource = this.companyBindingSource;
            this.cboxCompanyName.DisplayMember = "Name";
            this.cboxCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCompanyName.FormattingEnabled = true;
            this.cboxCompanyName.Location = new System.Drawing.Point(212, 137);
            this.cboxCompanyName.Name = "cboxCompanyName";
            this.cboxCompanyName.Size = new System.Drawing.Size(218, 28);
            this.cboxCompanyName.TabIndex = 0;
            this.cboxCompanyName.ValueMember = "CompanyId";
            this.cboxCompanyName.SelectedIndexChanged += new System.EventHandler(this.cboxCompanyName_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Barroc_Intens.Company);
            // 
            // cbMonthly
            // 
            this.cbMonthly.AutoSize = true;
            this.cbMonthly.Location = new System.Drawing.Point(213, 276);
            this.cbMonthly.Name = "cbMonthly";
            this.cbMonthly.Size = new System.Drawing.Size(110, 24);
            this.cbMonthly.TabIndex = 25;
            this.cbMonthly.Text = "Maandelijks";
            this.cbMonthly.UseVisualStyleBackColor = true;
            this.cbMonthly.Click += new System.EventHandler(this.cbMonthly_Click);
            // 
            // cbYearly
            // 
            this.cbYearly.AutoSize = true;
            this.cbYearly.Location = new System.Drawing.Point(329, 276);
            this.cbYearly.Name = "cbYearly";
            this.cbYearly.Size = new System.Drawing.Size(82, 24);
            this.cbYearly.TabIndex = 26;
            this.cbYearly.Text = "Jaarlijks";
            this.cbYearly.UseVisualStyleBackColor = true;
            this.cbYearly.Click += new System.EventHandler(this.cbYearly_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Factuurperiode";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbYearly);
            this.Controls.Add(this.cbMonthly);
            this.Controls.Add(this.cboxCompanyName);
            this.Controls.Add(this.btnDirectToFinanceDash);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.cbBkrCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmailAdresCompany);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.nudHourlyPrice);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.txbCompanyAdress);
            this.Controls.Add(this.lblHourlyPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCompanyAdress);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.nudHoursWorked);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.lblInvoice);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InvoiceForm";
            this.Text = "Factuurpagina";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAdress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblHourlyPrice;
        private System.Windows.Forms.TextBox txbCompanyAdress;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.NumericUpDown nudHourlyPrice;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmailAdresCompany;
        private System.Windows.Forms.CheckBox cbBkrCheck;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Button btnDirectToFinanceDash;
        private System.Windows.Forms.ComboBox cboxCompanyName;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.CheckBox cbMonthly;
        private System.Windows.Forms.CheckBox cbYearly;
        private System.Windows.Forms.Label label2;
    }
}