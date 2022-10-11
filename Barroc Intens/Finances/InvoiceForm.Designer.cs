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
            this.lblInvoice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAdress = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblHourlyPrice = new System.Windows.Forms.Label();
            this.txbCompanyAdress = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudHourlyPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(212, 172);
            this.txbCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(218, 27);
            this.txbCompanyName.TabIndex = 2;
            // 
            // nudHoursWorked
            // 
            this.nudHoursWorked.Location = new System.Drawing.Point(212, 370);
            this.nudHoursWorked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHoursWorked.Name = "nudHoursWorked";
            this.nudHoursWorked.Size = new System.Drawing.Size(218, 27);
            this.nudHoursWorked.TabIndex = 3;
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
            this.lblCompanyName.Location = new System.Drawing.Point(60, 176);
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
            this.lblDate.Location = new System.Drawing.Point(60, 249);
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
            this.lblHourlyPrice.Location = new System.Drawing.Point(62, 442);
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
            this.txbCompanyAdress.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 475);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 84);
            this.textBox3.TabIndex = 12;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(212, 242);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 27);
            this.dtpDate.TabIndex = 13;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(212, 405);
            this.nudDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(218, 27);
            this.nudDiscount.TabIndex = 14;
            // 
            // nudHourlyPrice
            // 
            this.nudHourlyPrice.Location = new System.Drawing.Point(212, 440);
            this.nudHourlyPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHourlyPrice.Name = "nudHourlyPrice";
            this.nudHourlyPrice.Size = new System.Drawing.Size(218, 27);
            this.nudHourlyPrice.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prijs per uur";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHourlyPrice);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txbCompanyAdress);
            this.Controls.Add(this.lblHourlyPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCompanyAdress);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.nudHoursWorked);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInvoice);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAdress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblHourlyPrice;
        private System.Windows.Forms.TextBox txbCompanyAdress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.NumericUpDown nudHourlyPrice;
        private System.Windows.Forms.Label label1;
    }
}