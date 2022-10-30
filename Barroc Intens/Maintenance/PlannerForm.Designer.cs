namespace Barroc_Intens.Maintenance
{
    partial class PlannerForm
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
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnBackToMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // btnBackToMaintenance
            // 
            this.btnBackToMaintenance.Location = new System.Drawing.Point(1489, 12);
            this.btnBackToMaintenance.Name = "btnBackToMaintenance";
            this.btnBackToMaintenance.Size = new System.Drawing.Size(168, 30);
            this.btnBackToMaintenance.TabIndex = 3;
            this.btnBackToMaintenance.Text = "Terug naar Dashboard";
            this.btnBackToMaintenance.UseVisualStyleBackColor = true;
            // 
            // PlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 706);
            this.Controls.Add(this.btnBackToMaintenance);
            this.Name = "PlannerForm";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlannerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnBackToMaintenance;
    }
}