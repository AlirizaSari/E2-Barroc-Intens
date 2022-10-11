namespace BarrocItems
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnMaintances = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinances
            // 
            this.btnFinances.Location = new System.Drawing.Point(815, 51);
            this.btnFinances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(86, 31);
            this.btnFinances.TabIndex = 0;
            this.btnFinances.Text = "Financieel";
            this.btnFinances.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(722, 51);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(86, 31);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Verkoop";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnPurchases
            // 
            this.btnPurchases.Location = new System.Drawing.Point(630, 51);
            this.btnPurchases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(86, 31);
            this.btnPurchases.TabIndex = 2;
            this.btnPurchases.Text = "Inkoop";
            this.btnPurchases.UseVisualStyleBackColor = true;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnMaintances
            // 
            this.btnMaintances.Location = new System.Drawing.Point(799, 89);
            this.btnMaintances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaintances.Name = "btnMaintances";
            this.btnMaintances.Size = new System.Drawing.Size(102, 31);
            this.btnMaintances.TabIndex = 3;
            this.btnMaintances.Text = "Onderhoud";
            this.btnMaintances.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarrocItems.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMaintances);
            this.Controls.Add(this.btnPurchases);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnFinances);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFinances;
        private Button btnSales;
        private Button btnPurchases;
        private Button btnMaintances;
        private PictureBox pictureBox1;
    }
}