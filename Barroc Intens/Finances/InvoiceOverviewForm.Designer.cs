﻿namespace Barroc_Intens
{
    partial class InvoiceOverviewForm
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
            this.btnBackToFinanceDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToFinanceDashboard
            // 
            this.btnBackToFinanceDashboard.Location = new System.Drawing.Point(644, 12);
            this.btnBackToFinanceDashboard.Name = "btnBackToFinanceDashboard";
            this.btnBackToFinanceDashboard.Size = new System.Drawing.Size(144, 56);
            this.btnBackToFinanceDashboard.TabIndex = 0;
            this.btnBackToFinanceDashboard.Text = "Terug naar finance dashboard";
            this.btnBackToFinanceDashboard.UseVisualStyleBackColor = true;
            this.btnBackToFinanceDashboard.Click += new System.EventHandler(this.btnBackToFinanceDashboard_Click);
            // 
            // InvoiceOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToFinanceDashboard);
            this.Name = "InvoiceOverviewForm";
            this.Text = "InvoiceOverviewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToFinanceDashboard;
    }
}