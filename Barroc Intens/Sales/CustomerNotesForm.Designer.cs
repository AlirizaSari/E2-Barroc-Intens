namespace Barroc_Intens.Sales
{
    partial class CustomerNotesForm
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
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.lblConversationReport = new System.Windows.Forms.Label();
            this.btnExportText = new System.Windows.Forms.Button();
            this.btnSaveToDb = new System.Windows.Forms.Button();
            this.btnRecallLastExport = new System.Windows.Forms.Button();
            this.btnExportToDocument = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblInvoervelden = new System.Windows.Forms.Label();
            this.txbConversationReport = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLogo
            // 
            this.pboxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(23, 11);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(75, 81);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            this.pboxLogo.Click += new System.EventHandler(this.pboxLogo_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMain.Location = new System.Drawing.Point(744, 10);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(116, 42);
            this.btnBackToMain.TabIndex = 3;
            this.btnBackToMain.Text = "Terug naar sales dashboard";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // lblConversationReport
            // 
            this.lblConversationReport.AutoSize = true;
            this.lblConversationReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversationReport.Location = new System.Drawing.Point(126, 81);
            this.lblConversationReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConversationReport.Name = "lblConversationReport";
            this.lblConversationReport.Size = new System.Drawing.Size(128, 20);
            this.lblConversationReport.TabIndex = 5;
            this.lblConversationReport.Text = "Gespreksverslag";
            // 
            // btnExportText
            // 
            this.btnExportText.Location = new System.Drawing.Point(366, 102);
            this.btnExportText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(128, 32);
            this.btnExportText.TabIndex = 6;
            this.btnExportText.Text = "<-- Exporteer";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // btnSaveToDb
            // 
            this.btnSaveToDb.Location = new System.Drawing.Point(366, 192);
            this.btnSaveToDb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveToDb.Name = "btnSaveToDb";
            this.btnSaveToDb.Size = new System.Drawing.Size(128, 32);
            this.btnSaveToDb.TabIndex = 7;
            this.btnSaveToDb.Text = "opslaan naar database";
            this.btnSaveToDb.UseVisualStyleBackColor = true;
            // 
            // btnRecallLastExport
            // 
            this.btnRecallLastExport.Location = new System.Drawing.Point(366, 147);
            this.btnRecallLastExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecallLastExport.Name = "btnRecallLastExport";
            this.btnRecallLastExport.Size = new System.Drawing.Size(128, 32);
            this.btnRecallLastExport.TabIndex = 8;
            this.btnRecallLastExport.Text = "Herstel";
            this.btnRecallLastExport.UseVisualStyleBackColor = true;
            // 
            // btnExportToDocument
            // 
            this.btnExportToDocument.Location = new System.Drawing.Point(366, 234);
            this.btnExportToDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportToDocument.Name = "btnExportToDocument";
            this.btnExportToDocument.Size = new System.Drawing.Size(128, 32);
            this.btnExportToDocument.TabIndex = 9;
            this.btnExportToDocument.Text = "opslaan naar document";
            this.btnExportToDocument.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(408, 72);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(49, 20);
            this.lblMenu.TabIndex = 10;
            this.lblMenu.Text = "Menu";
            // 
            // lblInvoervelden
            // 
            this.lblInvoervelden.AutoSize = true;
            this.lblInvoervelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoervelden.Location = new System.Drawing.Point(639, 72);
            this.lblInvoervelden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoervelden.Name = "lblInvoervelden";
            this.lblInvoervelden.Size = new System.Drawing.Size(99, 20);
            this.lblInvoervelden.TabIndex = 12;
            this.lblInvoervelden.Text = "Invoervelden";
            // 
            // txbConversationReport
            // 
            this.txbConversationReport.AcceptsReturn = true;
            this.txbConversationReport.Location = new System.Drawing.Point(23, 95);
            this.txbConversationReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbConversationReport.Multiline = true;
            this.txbConversationReport.Name = "txbConversationReport";
            this.txbConversationReport.Size = new System.Drawing.Size(339, 258);
            this.txbConversationReport.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(362, 257);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomerNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblConversationReport);
            this.Controls.Add(this.txbConversationReport);
            this.Controls.Add(this.lblInvoervelden);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnExportToDocument);
            this.Controls.Add(this.btnRecallLastExport);
            this.Controls.Add(this.btnSaveToDb);
            this.Controls.Add(this.btnExportText);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.pboxLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerNotesForm";
            this.Text = "CustomerNotesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Label lblConversationReport;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.Button btnSaveToDb;
        private System.Windows.Forms.Button btnRecallLastExport;
        private System.Windows.Forms.Button btnExportToDocument;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblInvoervelden;
        private System.Windows.Forms.TextBox txbConversationReport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}