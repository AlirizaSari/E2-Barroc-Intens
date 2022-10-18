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
            this.mcaMalfunctionCalendar = new System.Windows.Forms.MonthCalendar();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SuspendLayout();
            // 
            // mcaMalfunctionCalendar
            // 
            this.mcaMalfunctionCalendar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcaMalfunctionCalendar.Location = new System.Drawing.Point(253, 53);
            this.mcaMalfunctionCalendar.Name = "mcaMalfunctionCalendar";
            this.mcaMalfunctionCalendar.ShowWeekNumbers = true;
            this.mcaMalfunctionCalendar.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // PlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mcaMalfunctionCalendar);
            this.Name = "PlannerForm";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.PlannerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcaMalfunctionCalendar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}