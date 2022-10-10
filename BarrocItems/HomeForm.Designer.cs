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
            this.btnFinances.Location = new System.Drawing.Point(713, 38);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(75, 23);
            this.btnFinances.TabIndex = 0;
            this.btnFinances.Text = "Financieel";
            this.btnFinances.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(632, 38);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 23);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Verkoop";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnPurchases
            // 
            this.btnPurchases.Location = new System.Drawing.Point(551, 38);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(75, 23);
            this.btnPurchases.TabIndex = 2;
            this.btnPurchases.Text = "Inkoop";
            this.btnPurchases.UseVisualStyleBackColor = true;
            // 
            // btnMaintances
            // 
            this.btnMaintances.Location = new System.Drawing.Point(699, 67);
            this.btnMaintances.Name = "btnMaintances";
            this.btnMaintances.Size = new System.Drawing.Size(89, 23);
            this.btnMaintances.TabIndex = 3;
            this.btnMaintances.Text = "Onderhoud";
            this.btnMaintances.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarrocItems.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 89);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMaintances);
            this.Controls.Add(this.btnPurchases);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnFinances);
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