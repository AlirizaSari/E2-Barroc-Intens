namespace Barroc_Intens
{
    partial class DashboardAdminForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.txbExtraInfo = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnDirectToFinances = new System.Windows.Forms.Button();
            this.btnDirectToMarketing = new System.Windows.Forms.Button();
            this.btnDirectToMaintenance = new System.Windows.Forms.Button();
            this.btnDirectToSales = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
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
            this.lblExtraInfo.Size = new System.Drawing.Size(91, 15);
            this.lblExtraInfo.TabIndex = 6;
            this.lblExtraInfo.Text = "Extra Informatie";
            // 
            // txbExtraInfo
            // 
            this.txbExtraInfo.Location = new System.Drawing.Point(24, 345);
            this.txbExtraInfo.Multiline = true;
            this.txbExtraInfo.Name = "txbExtraInfo";
            this.txbExtraInfo.Size = new System.Drawing.Size(162, 160);
            this.txbExtraInfo.TabIndex = 5;
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
            this.lblDepartment.Size = new System.Drawing.Size(52, 15);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Afdeling";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(53, 220);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(87, 15);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Account Naam";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(61, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.lblSystemName);
            this.pnlTop.Location = new System.Drawing.Point(222, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(692, 157);
            this.pnlTop.TabIndex = 1;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(313, 34);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(90, 32);
            this.lblSystemName.TabIndex = 3;
            this.lblSystemName.Text = "Admin";
            // 
            // btnDirectToFinances
            // 
            this.btnDirectToFinances.Location = new System.Drawing.Point(291, 185);
            this.btnDirectToFinances.Name = "btnDirectToFinances";
            this.btnDirectToFinances.Size = new System.Drawing.Size(259, 84);
            this.btnDirectToFinances.TabIndex = 1;
            this.btnDirectToFinances.Text = "Finances";
            this.btnDirectToFinances.UseVisualStyleBackColor = true;
            this.btnDirectToFinances.Click += new System.EventHandler(this.btnDirectToFinances_Click);
            // 
            // btnDirectToMarketing
            // 
            this.btnDirectToMarketing.Location = new System.Drawing.Point(594, 185);
            this.btnDirectToMarketing.Name = "btnDirectToMarketing";
            this.btnDirectToMarketing.Size = new System.Drawing.Size(259, 84);
            this.btnDirectToMarketing.TabIndex = 0;
            this.btnDirectToMarketing.Text = "Inkoop";
            this.btnDirectToMarketing.UseVisualStyleBackColor = true;
            this.btnDirectToMarketing.Click += new System.EventHandler(this.btnDirectToMarketing_Click);
            // 
            // btnDirectToMaintenance
            // 
            this.btnDirectToMaintenance.Location = new System.Drawing.Point(291, 301);
            this.btnDirectToMaintenance.Name = "btnDirectToMaintenance";
            this.btnDirectToMaintenance.Size = new System.Drawing.Size(259, 84);
            this.btnDirectToMaintenance.TabIndex = 2;
            this.btnDirectToMaintenance.Text = "Maintenance";
            this.btnDirectToMaintenance.UseVisualStyleBackColor = true;
            this.btnDirectToMaintenance.Click += new System.EventHandler(this.btnDirectToMaintenance_Click);
            // 
            // btnDirectToSales
            // 
            this.btnDirectToSales.Location = new System.Drawing.Point(594, 301);
            this.btnDirectToSales.Name = "btnDirectToSales";
            this.btnDirectToSales.Size = new System.Drawing.Size(259, 84);
            this.btnDirectToSales.TabIndex = 3;
            this.btnDirectToSales.Text = "Sales";
            this.btnDirectToSales.UseVisualStyleBackColor = true;
            this.btnDirectToSales.Click += new System.EventHandler(this.btnDirectToSales_Click);
            // 
            // DashboardAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnDirectToSales);
            this.Controls.Add(this.btnDirectToMaintenance);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.btnDirectToFinances);
            this.Controls.Add(this.btnDirectToMarketing);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardAdminForm";
            this.Text = "Dashboard voor admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardAdminForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
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
        private System.Windows.Forms.Button btnDirectToFinances;
        private System.Windows.Forms.Button btnDirectToMarketing;
        private System.Windows.Forms.Button btnDirectToMaintenance;
        private System.Windows.Forms.Button btnDirectToSales;
    }
}