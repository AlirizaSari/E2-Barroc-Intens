using System.Windows.Forms;

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
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblDateInvoice = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCompanyAdress = new System.Windows.Forms.Label();
            this.txbCompanyAdress = new System.Windows.Forms.TextBox();
            this.lblDivider = new System.Windows.Forms.Label();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txbComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblPricePerHour = new System.Windows.Forms.Label();
            this.nudPricePerHour = new System.Windows.Forms.NumericUpDown();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerHour)).BeginInit();
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
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(207, 152);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(250, 27);
            this.txbCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(31, 152);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(149, 20);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Naam van het bedrijf";
            // 
            // lblDateInvoice
            // 
            this.lblDateInvoice.AutoSize = true;
            this.lblDateInvoice.Location = new System.Drawing.Point(31, 190);
            this.lblDateInvoice.Name = "lblDateInvoice";
            this.lblDateInvoice.Size = new System.Drawing.Size(54, 20);
            this.lblDateInvoice.TabIndex = 4;
            this.lblDateInvoice.Text = "Datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(207, 185);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 5;
            // 
            // lblCompanyAdress
            // 
            this.lblCompanyAdress.AutoSize = true;
            this.lblCompanyAdress.Location = new System.Drawing.Point(31, 221);
            this.lblCompanyAdress.Name = "lblCompanyAdress";
            this.lblCompanyAdress.Size = new System.Drawing.Size(147, 20);
            this.lblCompanyAdress.TabIndex = 7;
            this.lblCompanyAdress.Text = "Adres van het bedrijf";
            // 
            // txbCompanyAdress
            // 
            this.txbCompanyAdress.Location = new System.Drawing.Point(207, 218);
            this.txbCompanyAdress.Name = "txbCompanyAdress";
            this.txbCompanyAdress.Size = new System.Drawing.Size(250, 27);
            this.txbCompanyAdress.TabIndex = 6;
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(1, 321);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(918, 2);
            this.lblDivider.TabIndex = 8;
            // 
            // nudHoursWorked
            // 
            this.nudHoursWorked.Location = new System.Drawing.Point(207, 349);
            this.nudHoursWorked.Name = "nudHoursWorked";
            this.nudHoursWorked.Size = new System.Drawing.Size(250, 27);
            this.nudHoursWorked.TabIndex = 9;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(31, 351);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(97, 20);
            this.lblHoursWorked.TabIndex = 10;
            this.lblHoursWorked.Text = "Uren gewerkt";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(31, 451);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(118, 20);
            this.lblComments.TabIndex = 12;
            this.lblComments.Text = "Aantekening(en)";
            // 
            // txbComments
            // 
            this.txbComments.Location = new System.Drawing.Point(207, 448);
            this.txbComments.Multiline = true;
            this.txbComments.Name = "txbComments";
            this.txbComments.Size = new System.Drawing.Size(250, 89);
            this.txbComments.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Korting";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(207, 382);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(250, 27);
            this.nudDiscount.TabIndex = 15;
            // 
            // lblPricePerHour
            // 
            this.lblPricePerHour.AutoSize = true;
            this.lblPricePerHour.Location = new System.Drawing.Point(31, 417);
            this.lblPricePerHour.Name = "lblPricePerHour";
            this.lblPricePerHour.Size = new System.Drawing.Size(87, 20);
            this.lblPricePerHour.TabIndex = 16;
            this.lblPricePerHour.Text = "Prijs per uur";
            // 
            // nudPricePerHour
            // 
            this.nudPricePerHour.Location = new System.Drawing.Point(207, 415);
            this.nudPricePerHour.Name = "nudPricePerHour";
            this.nudPricePerHour.Size = new System.Drawing.Size(250, 27);
            this.nudPricePerHour.TabIndex = 17;
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Location = new System.Drawing.Point(664, 349);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(171, 46);
            this.btnCreateInvoice.TabIndex = 18;
            this.btnCreateInvoice.Text = "Creëer factuur";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(664, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 46);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Voeg toe aan factuur";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(416, 553);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 20;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.nudPricePerHour);
            this.Controls.Add(this.lblPricePerHour);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.nudHoursWorked);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblCompanyAdress);
            this.Controls.Add(this.txbCompanyAdress);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDateInvoice);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.lblFactuur);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFactuur;
        private TextBox txbCompanyName;
        private Label lblCompanyName;
        private Label lblDateInvoice;
        private DateTimePicker dtpDate;
        private Label lblCompanyAdress;
        private TextBox txbCompanyAdress;
        private Label lblDivider;
        private NumericUpDown nudHoursWorked;
        private Label lblHoursWorked;
        private Label lblComments;
        private TextBox txbComments;
        private Label label2;
        private NumericUpDown nudDiscount;
        private Label lblPricePerHour;
        private NumericUpDown nudPricePerHour;
        private Button btnCreateInvoice;
        private Button btnAdd;
        private Label lblError;
    }
}