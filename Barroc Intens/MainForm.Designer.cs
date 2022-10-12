namespace Barroc_Intens
{
    partial class MainForm
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
            this.btnDirectToFinances = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDirectToSales = new System.Windows.Forms.Button();
            this.btnDirectToMaintenance = new System.Windows.Forms.Button();
            this.btnDirectToInkoop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectToFinances
            // 
            this.btnDirectToFinances.Location = new System.Drawing.Point(588, 76);
            this.btnDirectToFinances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirectToFinances.Name = "btnDirectToFinances";
            this.btnDirectToFinances.Size = new System.Drawing.Size(104, 39);
            this.btnDirectToFinances.TabIndex = 0;
            this.btnDirectToFinances.Text = "Finances";
            this.btnDirectToFinances.UseVisualStyleBackColor = true;
            this.btnDirectToFinances.Click += new System.EventHandler(this.btnDirectToFinances_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDirectToSales
            // 
            this.btnDirectToSales.Location = new System.Drawing.Point(588, 132);
            this.btnDirectToSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirectToSales.Name = "btnDirectToSales";
            this.btnDirectToSales.Size = new System.Drawing.Size(104, 39);
            this.btnDirectToSales.TabIndex = 2;
            this.btnDirectToSales.Text = "Sales";
            this.btnDirectToSales.UseVisualStyleBackColor = true;
            this.btnDirectToSales.Click += new System.EventHandler(this.btnDirectToSales_Click);
            // 
            // btnDirectToMaintenance
            // 
            this.btnDirectToMaintenance.Location = new System.Drawing.Point(712, 132);
            this.btnDirectToMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirectToMaintenance.Name = "btnDirectToMaintenance";
            this.btnDirectToMaintenance.Size = new System.Drawing.Size(104, 39);
            this.btnDirectToMaintenance.TabIndex = 3;
            this.btnDirectToMaintenance.Text = "Maintenance";
            this.btnDirectToMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnDirectToInkoop
            // 
            this.btnDirectToInkoop.Location = new System.Drawing.Point(712, 76);
            this.btnDirectToInkoop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirectToInkoop.Name = "btnDirectToInkoop";
            this.btnDirectToInkoop.Size = new System.Drawing.Size(104, 39);
            this.btnDirectToInkoop.TabIndex = 4;
            this.btnDirectToInkoop.Text = "Inkoop";
            this.btnDirectToInkoop.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 601);
            this.Controls.Add(this.btnDirectToInkoop);
            this.Controls.Add(this.btnDirectToMaintenance);
            this.Controls.Add(this.btnDirectToSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDirectToFinances);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDirectToFinances;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDirectToSales;
        private System.Windows.Forms.Button btnDirectToMaintenance;
        private System.Windows.Forms.Button btnDirectToInkoop;
    }
}

