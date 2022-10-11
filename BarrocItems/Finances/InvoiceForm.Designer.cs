namespace BarrocItems.Finances
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
            this.lblFactuur = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblDateInvoice = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCompanyAdress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFactuur
            // 
            this.lblFactuur.AutoSize = true;
            this.lblFactuur.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFactuur.Location = new System.Drawing.Point(416, 59);
            this.lblFactuur.Name = "lblFactuur";
            this.lblFactuur.Size = new System.Drawing.Size(99, 27);
            this.lblFactuur.TabIndex = 0;
            this.lblFactuur.Text = "Factuur";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(33, 155);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(149, 20);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Naam van het bedrijf";
            // 
            // lblDateInvoice
            // 
            this.lblDateInvoice.AutoSize = true;
            this.lblDateInvoice.Location = new System.Drawing.Point(33, 207);
            this.lblDateInvoice.Name = "lblDateInvoice";
            this.lblDateInvoice.Size = new System.Drawing.Size(54, 20);
            this.lblDateInvoice.TabIndex = 4;
            this.lblDateInvoice.Text = "Datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblCompanyAdress
            // 
            this.lblCompanyAdress.AutoSize = true;
            this.lblCompanyAdress.Location = new System.Drawing.Point(33, 255);
            this.lblCompanyAdress.Name = "lblCompanyAdress";
            this.lblCompanyAdress.Size = new System.Drawing.Size(147, 20);
            this.lblCompanyAdress.TabIndex = 7;
            this.lblCompanyAdress.Text = "Adres van het bedrijf";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 27);
            this.textBox2.TabIndex = 6;
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(-2, 313);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(918, 10);
            this.lblDivider.TabIndex = 8;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblCompanyAdress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDateInvoice);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFactuur);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFactuur;
        private TextBox textBox1;
        private Label lblCompanyName;
        private Label lblDateInvoice;
        private DateTimePicker dateTimePicker1;
        private Label lblCompanyAdress;
        private TextBox textBox2;
        private Label lblDivider;
    }
}