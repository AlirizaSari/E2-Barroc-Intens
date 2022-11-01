namespace Barroc_Intens.Maintenance
{
    partial class MaintenanceForm
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
            this.maintenanceAppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBackToMaintenance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // maintenanceAppointmentDataGridView
            // 
            this.maintenanceAppointmentDataGridView.AutoGenerateColumns = false;
            this.maintenanceAppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceAppointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.addedDataGridViewTextBoxColumn,
            this.AppointmentDate,
            this.AppointmentTime,
            this.User});
            this.maintenanceAppointmentDataGridView.DataSource = this.maintenanceAppointmentBindingSource;
            this.maintenanceAppointmentDataGridView.Location = new System.Drawing.Point(158, 130);
            this.maintenanceAppointmentDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceAppointmentDataGridView.Name = "maintenanceAppointmentDataGridView";
            this.maintenanceAppointmentDataGridView.RowHeadersWidth = 51;
            this.maintenanceAppointmentDataGridView.Size = new System.Drawing.Size(744, 354);
            this.maintenanceAppointmentDataGridView.TabIndex = 1;
            this.maintenanceAppointmentDataGridView.SelectionChanged += new System.EventHandler(this.maintenanceAppointmentDataGridView_SelectionChanged);
            // 
            // btnBackToMaintenance
            // 
            this.btnBackToMaintenance.Location = new System.Drawing.Point(719, 15);
            this.btnBackToMaintenance.Name = "btnBackToMaintenance";
            this.btnBackToMaintenance.Size = new System.Drawing.Size(168, 30);
            this.btnBackToMaintenance.TabIndex = 2;
            this.btnBackToMaintenance.Text = "Terug naar Dashboard";
            this.btnBackToMaintenance.UseVisualStyleBackColor = true;
            this.btnBackToMaintenance.Click += new System.EventHandler(this.btnBackToMaintenance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Storings Afspraken";
            // 
            // maintenanceAppointmentBindingSource
            // 
            this.maintenanceAppointmentBindingSource.DataSource = typeof(Barroc_Intens.MaintenanceAppointment);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Barroc_Intens.Product);
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // addedDataGridViewTextBoxColumn
            // 
            this.addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            this.addedDataGridViewTextBoxColumn.HeaderText = "Added";
            this.addedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            this.addedDataGridViewTextBoxColumn.Width = 125;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.HeaderText = "AppointmentDate";
            this.AppointmentDate.Name = "AppointmentDate";
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.DataPropertyName = "AppointmentTime";
            this.AppointmentTime.HeaderText = "AppointmentTime";
            this.AppointmentTime.Name = "AppointmentTime";
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToMaintenance);
            this.Controls.Add(this.maintenanceAppointmentDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MaintenanceForm";
            this.Text = "MaintenanceForm";
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView maintenanceAppointmentDataGridView;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btnBackToMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}