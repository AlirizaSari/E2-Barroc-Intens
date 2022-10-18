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
            this.pboxLogo.Location = new System.Drawing.Point(31, 13);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            this.pboxLogo.Click += new System.EventHandler(this.pboxLogo_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMain.Location = new System.Drawing.Point(1034, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(112, 52);
            this.btnBackToMain.TabIndex = 3;
            this.btnBackToMain.Text = "Terug naar hoofd pagina";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // lblConversationReport
            // 
            this.lblConversationReport.AutoSize = true;
            this.lblConversationReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversationReport.Location = new System.Drawing.Point(168, 100);
            this.lblConversationReport.Name = "lblConversationReport";
            this.lblConversationReport.Size = new System.Drawing.Size(159, 25);
            this.lblConversationReport.TabIndex = 5;
            this.lblConversationReport.Text = "Gespreksverslag";
            // 
            // btnExportText
            // 
            this.btnExportText.Location = new System.Drawing.Point(488, 126);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(170, 39);
            this.btnExportText.TabIndex = 6;
            this.btnExportText.Text = "<-- Exporteer";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // btnSaveToDb
            // 
            this.btnSaveToDb.Location = new System.Drawing.Point(488, 236);
            this.btnSaveToDb.Name = "btnSaveToDb";
            this.btnSaveToDb.Size = new System.Drawing.Size(170, 39);
            this.btnSaveToDb.TabIndex = 7;
            this.btnSaveToDb.Text = "opslaan naar database";
            this.btnSaveToDb.UseVisualStyleBackColor = true;
            // 
            // btnRecallLastExport
            // 
            this.btnRecallLastExport.Location = new System.Drawing.Point(488, 181);
            this.btnRecallLastExport.Name = "btnRecallLastExport";
            this.btnRecallLastExport.Size = new System.Drawing.Size(170, 39);
            this.btnRecallLastExport.TabIndex = 8;
            this.btnRecallLastExport.Text = "Herstel";
            this.btnRecallLastExport.UseVisualStyleBackColor = true;
            // 
            // btnExportToDocument
            // 
            this.btnExportToDocument.Location = new System.Drawing.Point(488, 288);
            this.btnExportToDocument.Name = "btnExportToDocument";
            this.btnExportToDocument.Size = new System.Drawing.Size(170, 39);
            this.btnExportToDocument.TabIndex = 9;
            this.btnExportToDocument.Text = "opslaan naar document";
            this.btnExportToDocument.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(544, 89);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(62, 25);
            this.lblMenu.TabIndex = 10;
            this.lblMenu.Text = "Menu";
            // 
            // lblInvoervelden
            // 
            this.lblInvoervelden.AutoSize = true;
            this.lblInvoervelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoervelden.Location = new System.Drawing.Point(852, 89);
            this.lblInvoervelden.Name = "lblInvoervelden";
            this.lblInvoervelden.Size = new System.Drawing.Size(124, 25);
            this.lblInvoervelden.TabIndex = 12;
            this.lblInvoervelden.Text = "Invoervelden";
            // 
            // txbConversationReport
            // 
            this.txbConversationReport.AcceptsReturn = true;
            this.txbConversationReport.Location = new System.Drawing.Point(31, 117);
            this.txbConversationReport.Multiline = true;
            this.txbConversationReport.Name = "txbConversationReport";
            this.txbConversationReport.Size = new System.Drawing.Size(451, 316);
            this.txbConversationReport.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(664, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 316);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomerNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 589);
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