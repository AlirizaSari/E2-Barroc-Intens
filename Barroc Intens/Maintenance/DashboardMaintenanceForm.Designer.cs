namespace Barroc_Intens
{
    partial class DashboardMaintenanceForm
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
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnMaintenancePlanner = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnPartsForm = new System.Windows.Forms.Button();
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
            this.pboxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(61, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            this.pboxLogo.Click += new System.EventHandler(this.pboxLogo_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.btnPartsForm);
            this.pnlTop.Controls.Add(this.lblSystemName);
            this.pnlTop.Controls.Add(this.btnBackToMain);
            this.pnlTop.Controls.Add(this.btnMaintenancePlanner);
            this.pnlTop.Controls.Add(this.btnMaintenance);
            this.pnlTop.Location = new System.Drawing.Point(222, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(923, 157);
            this.pnlTop.TabIndex = 1;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(385, 39);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(162, 32);
            this.lblSystemName.TabIndex = 3;
            this.lblSystemName.Text = "Maintenance";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(40, 117);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(172, 37);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Home";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnMaintenancePlanner
            // 
            this.btnMaintenancePlanner.Location = new System.Drawing.Point(495, 117);
            this.btnMaintenancePlanner.Name = "btnMaintenancePlanner";
            this.btnMaintenancePlanner.Size = new System.Drawing.Size(172, 37);
            this.btnMaintenancePlanner.TabIndex = 2;
            this.btnMaintenancePlanner.Text = "Planner";
            this.btnMaintenancePlanner.UseVisualStyleBackColor = true;
            this.btnMaintenancePlanner.Click += new System.EventHandler(this.btnMaintenancePlanner_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(264, 117);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(172, 37);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnPartsForm
            // 
            this.btnPartsForm.Location = new System.Drawing.Point(722, 117);
            this.btnPartsForm.Name = "btnPartsForm";
            this.btnPartsForm.Size = new System.Drawing.Size(172, 37);
            this.btnPartsForm.TabIndex = 4;
            this.btnPartsForm.Text = "Onderdelen";
            this.btnPartsForm.UseVisualStyleBackColor = true;
            this.btnPartsForm.Click += new System.EventHandler(this.btnPartsForm_Click);
            // 
            // DashboardMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 600);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardMaintenanceForm";
            this.Text = "Dashboard voor maintenance";
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
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnMaintenancePlanner;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnPartsForm;
    }
}