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
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlCalander = new System.Windows.Forms.Panel();
            this.pnlAppointmentList = new System.Windows.Forms.Panel();
            this.pnlAppointmentDetails = new System.Windows.Forms.Panel();
            this.mcMaintanence = new System.Windows.Forms.MonthCalendar();
            this.lblCalanderHeader = new System.Windows.Forms.Label();
            this.lblOpenMaintenceTicketsCounter = new System.Windows.Forms.Label();
            this.lblCurrentNumberOfOpenTickets = new System.Windows.Forms.Label();
            this.lblCurrentNumberOfFinishedTickets = new System.Windows.Forms.Label();
            this.lblFinishedticketCounter = new System.Windows.Forms.Label();
            this.lblAppointmentListHeader = new System.Windows.Forms.Label();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.lblSelectedDateTitle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbxCompanyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbxLocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbxEmployeeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDetailsHeader = new System.Windows.Forms.Label();
            this.lblAdresCompany = new System.Windows.Forms.Label();
            this.lblCityCompany = new System.Windows.Forms.Label();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblCommentsCompany = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txbCommandsAppointment = new System.Windows.Forms.TextBox();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlCalander.SuspendLayout();
            this.pnlAppointmentList.SuspendLayout();
            this.pnlAppointmentDetails.SuspendLayout();
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
            this.btnBackToMaintenance.Location = new System.Drawing.Point(1076, 16);
            this.btnBackToMaintenance.Name = "btnBackToMaintenance";
            this.btnBackToMaintenance.Size = new System.Drawing.Size(168, 108);
            this.btnBackToMaintenance.TabIndex = 3;
            this.btnBackToMaintenance.Text = "Terug naar Dashboard";
            this.btnBackToMaintenance.UseVisualStyleBackColor = true;
            this.btnBackToMaintenance.Click += new System.EventHandler(this.btnBackToMaintenance_Click);
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Controls.Add(this.lblFormTitle);
            this.pnlTopMenu.Controls.Add(this.btnBackToMaintenance);
            this.pnlTopMenu.Controls.Add(this.pboxLogo);
            this.pnlTopMenu.Location = new System.Drawing.Point(2, -4);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1260, 142);
            this.pnlTopMenu.TabIndex = 4;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(0, 0);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(152, 138);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(442, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(392, 46);
            this.lblFormTitle.TabIndex = 3;
            this.lblFormTitle.Text = "onderhouds planner";
            // 
            // pnlCalander
            // 
            this.pnlCalander.Controls.Add(this.lblCurrentNumberOfFinishedTickets);
            this.pnlCalander.Controls.Add(this.lblFinishedticketCounter);
            this.pnlCalander.Controls.Add(this.lblCurrentNumberOfOpenTickets);
            this.pnlCalander.Controls.Add(this.lblOpenMaintenceTicketsCounter);
            this.pnlCalander.Controls.Add(this.lblCalanderHeader);
            this.pnlCalander.Controls.Add(this.mcMaintanence);
            this.pnlCalander.Location = new System.Drawing.Point(12, 145);
            this.pnlCalander.Name = "pnlCalander";
            this.pnlCalander.Size = new System.Drawing.Size(401, 535);
            this.pnlCalander.TabIndex = 5;
            // 
            // pnlAppointmentList
            // 
            this.pnlAppointmentList.Controls.Add(this.listView1);
            this.pnlAppointmentList.Controls.Add(this.lblSelectedDateTitle);
            this.pnlAppointmentList.Controls.Add(this.lblSelectedDate);
            this.pnlAppointmentList.Controls.Add(this.lblAppointmentListHeader);
            this.pnlAppointmentList.Location = new System.Drawing.Point(419, 145);
            this.pnlAppointmentList.Name = "pnlAppointmentList";
            this.pnlAppointmentList.Size = new System.Drawing.Size(416, 535);
            this.pnlAppointmentList.TabIndex = 6;
            // 
            // pnlAppointmentDetails
            // 
            this.pnlAppointmentDetails.Controls.Add(this.button3);
            this.pnlAppointmentDetails.Controls.Add(this.button2);
            this.pnlAppointmentDetails.Controls.Add(this.btnEditDetails);
            this.pnlAppointmentDetails.Controls.Add(this.txbCommandsAppointment);
            this.pnlAppointmentDetails.Controls.Add(this.lblCompanyName);
            this.pnlAppointmentDetails.Controls.Add(this.lblCommentsCompany);
            this.pnlAppointmentDetails.Controls.Add(this.lblDateAdded);
            this.pnlAppointmentDetails.Controls.Add(this.lblCityCompany);
            this.pnlAppointmentDetails.Controls.Add(this.lblAdresCompany);
            this.pnlAppointmentDetails.Controls.Add(this.lblDetailsHeader);
            this.pnlAppointmentDetails.Location = new System.Drawing.Point(847, 145);
            this.pnlAppointmentDetails.Name = "pnlAppointmentDetails";
            this.pnlAppointmentDetails.Size = new System.Drawing.Size(401, 535);
            this.pnlAppointmentDetails.TabIndex = 7;
            // 
            // mcMaintanence
            // 
            this.mcMaintanence.Location = new System.Drawing.Point(72, 63);
            this.mcMaintanence.Name = "mcMaintanence";
            this.mcMaintanence.TabIndex = 0;
            // 
            // lblCalanderHeader
            // 
            this.lblCalanderHeader.AutoSize = true;
            this.lblCalanderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalanderHeader.Location = new System.Drawing.Point(114, 14);
            this.lblCalanderHeader.Name = "lblCalanderHeader";
            this.lblCalanderHeader.Size = new System.Drawing.Size(172, 40);
            this.lblCalanderHeader.TabIndex = 1;
            this.lblCalanderHeader.Text = "kalender\r\ndag / week /maand ";
            this.lblCalanderHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOpenMaintenceTicketsCounter
            // 
            this.lblOpenMaintenceTicketsCounter.AutoSize = true;
            this.lblOpenMaintenceTicketsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenMaintenceTicketsCounter.Location = new System.Drawing.Point(32, 315);
            this.lblOpenMaintenceTicketsCounter.Name = "lblOpenMaintenceTicketsCounter";
            this.lblOpenMaintenceTicketsCounter.Size = new System.Drawing.Size(323, 20);
            this.lblOpenMaintenceTicketsCounter.TabIndex = 2;
            this.lblOpenMaintenceTicketsCounter.Text = "openstaande bezoeken voor vandaag:";
            // 
            // lblCurrentNumberOfOpenTickets
            // 
            this.lblCurrentNumberOfOpenTickets.AutoSize = true;
            this.lblCurrentNumberOfOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNumberOfOpenTickets.Location = new System.Drawing.Point(72, 339);
            this.lblCurrentNumberOfOpenTickets.Name = "lblCurrentNumberOfOpenTickets";
            this.lblCurrentNumberOfOpenTickets.Size = new System.Drawing.Size(105, 20);
            this.lblCurrentNumberOfOpenTickets.TabIndex = 3;
            this.lblCurrentNumberOfOpenTickets.Text = "(x) bezoeken";
            // 
            // lblCurrentNumberOfFinishedTickets
            // 
            this.lblCurrentNumberOfFinishedTickets.AutoSize = true;
            this.lblCurrentNumberOfFinishedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNumberOfFinishedTickets.Location = new System.Drawing.Point(72, 409);
            this.lblCurrentNumberOfFinishedTickets.Name = "lblCurrentNumberOfFinishedTickets";
            this.lblCurrentNumberOfFinishedTickets.Size = new System.Drawing.Size(105, 20);
            this.lblCurrentNumberOfFinishedTickets.TabIndex = 5;
            this.lblCurrentNumberOfFinishedTickets.Text = "(x) bezoeken";
            // 
            // lblFinishedticketCounter
            // 
            this.lblFinishedticketCounter.AutoSize = true;
            this.lblFinishedticketCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishedticketCounter.Location = new System.Drawing.Point(32, 385);
            this.lblFinishedticketCounter.Name = "lblFinishedticketCounter";
            this.lblFinishedticketCounter.Size = new System.Drawing.Size(301, 20);
            this.lblFinishedticketCounter.TabIndex = 4;
            this.lblFinishedticketCounter.Text = "afgewerkte bezoeken van vandaag:";
            // 
            // lblAppointmentListHeader
            // 
            this.lblAppointmentListHeader.AutoSize = true;
            this.lblAppointmentListHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentListHeader.Location = new System.Drawing.Point(91, 21);
            this.lblAppointmentListHeader.Name = "lblAppointmentListHeader";
            this.lblAppointmentListHeader.Size = new System.Drawing.Size(231, 20);
            this.lblAppointmentListHeader.TabIndex = 0;
            this.lblAppointmentListHeader.Text = "onderhouds afspraken lijst";
            this.lblAppointmentListHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.Location = new System.Drawing.Point(245, 63);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(113, 20);
            this.lblSelectedDate.TabIndex = 1;
            this.lblSelectedDate.Text = "DD/MM/YYYY";
            // 
            // lblSelectedDateTitle
            // 
            this.lblSelectedDateTitle.AutoSize = true;
            this.lblSelectedDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDateTitle.Location = new System.Drawing.Point(69, 63);
            this.lblSelectedDateTitle.Name = "lblSelectedDateTitle";
            this.lblSelectedDateTitle.Size = new System.Drawing.Size(170, 20);
            this.lblSelectedDateTitle.TabIndex = 2;
            this.lblSelectedDateTitle.Text = "geselecteerde datum:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lbxCompanyHeader,
            this.lbxLocationHeader,
            this.lbxEmployeeHeader});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 425);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbxCompanyHeader
            // 
            this.lbxCompanyHeader.Text = "Bedrijf";
            // 
            // lbxLocationHeader
            // 
            this.lbxLocationHeader.Text = "Locatie";
            // 
            // lbxEmployeeHeader
            // 
            this.lbxEmployeeHeader.Text = "Medewerker";
            // 
            // lblDetailsHeader
            // 
            this.lblDetailsHeader.AutoSize = true;
            this.lblDetailsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHeader.Location = new System.Drawing.Point(126, 21);
            this.lblDetailsHeader.Name = "lblDetailsHeader";
            this.lblDetailsHeader.Size = new System.Drawing.Size(145, 20);
            this.lblDetailsHeader.TabIndex = 0;
            this.lblDetailsHeader.Text = "Afspraak details";
            // 
            // lblAdresCompany
            // 
            this.lblAdresCompany.AutoSize = true;
            this.lblAdresCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresCompany.Location = new System.Drawing.Point(30, 109);
            this.lblAdresCompany.Name = "lblAdresCompany";
            this.lblAdresCompany.Size = new System.Drawing.Size(55, 17);
            this.lblAdresCompany.TabIndex = 1;
            this.lblAdresCompany.Text = "Adres:";
            //this.lblAdresCompany.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCityCompany
            // 
            this.lblCityCompany.AutoSize = true;
            this.lblCityCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityCompany.Location = new System.Drawing.Point(30, 164);
            this.lblCityCompany.Name = "lblCityCompany";
            this.lblCityCompany.Size = new System.Drawing.Size(46, 17);
            this.lblCityCompany.TabIndex = 2;
            this.lblCityCompany.Text = "Stad:";
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAdded.Location = new System.Drawing.Point(30, 219);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(180, 17);
            this.lblDateAdded.TabIndex = 3;
            this.lblDateAdded.Text = "afspraak toegevoed op:";
            // 
            // lblCommentsCompany
            // 
            this.lblCommentsCompany.AutoSize = true;
            this.lblCommentsCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentsCompany.Location = new System.Drawing.Point(30, 274);
            this.lblCommentsCompany.Name = "lblCommentsCompany";
            this.lblCommentsCompany.Size = new System.Drawing.Size(106, 17);
            this.lblCommentsCompany.TabIndex = 4;
            this.lblCommentsCompany.Text = "opmerkingen:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(145, 63);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(126, 20);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Bedrijfs naam";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbCommandsAppointment
            // 
            this.txbCommandsAppointment.Location = new System.Drawing.Point(33, 305);
            this.txbCommandsAppointment.Multiline = true;
            this.txbCommandsAppointment.Name = "txbCommandsAppointment";
            this.txbCommandsAppointment.ReadOnly = true;
            this.txbCommandsAppointment.Size = new System.Drawing.Size(351, 151);
            this.txbCommandsAppointment.TabIndex = 6;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(33, 462);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(103, 33);
            this.btnEditDetails.TabIndex = 7;
            this.btnEditDetails.Text = "edit details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 687);
            this.Controls.Add(this.pnlAppointmentDetails);
            this.Controls.Add(this.pnlAppointmentList);
            this.Controls.Add(this.pnlCalander);
            this.Controls.Add(this.pnlTopMenu);
            this.Name = "PlannerForm";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlannerForm_Load);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlCalander.ResumeLayout(false);
            this.pnlCalander.PerformLayout();
            this.pnlAppointmentList.ResumeLayout(false);
            this.pnlAppointmentList.PerformLayout();
            this.pnlAppointmentDetails.ResumeLayout(false);
            this.pnlAppointmentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnBackToMaintenance;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel pnlCalander;
        private System.Windows.Forms.Panel pnlAppointmentList;
        private System.Windows.Forms.Panel pnlAppointmentDetails;
        private System.Windows.Forms.Label lblOpenMaintenceTicketsCounter;
        private System.Windows.Forms.Label lblCalanderHeader;
        private System.Windows.Forms.MonthCalendar mcMaintanence;
        private System.Windows.Forms.Label lblCurrentNumberOfFinishedTickets;
        private System.Windows.Forms.Label lblFinishedticketCounter;
        private System.Windows.Forms.Label lblCurrentNumberOfOpenTickets;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lbxCompanyHeader;
        private System.Windows.Forms.ColumnHeader lbxLocationHeader;
        private System.Windows.Forms.ColumnHeader lbxEmployeeHeader;
        private System.Windows.Forms.Label lblSelectedDateTitle;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Label lblAppointmentListHeader;
        private System.Windows.Forms.Label lblAdresCompany;
        private System.Windows.Forms.Label lblDetailsHeader;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCommentsCompany;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblCityCompany;
        private System.Windows.Forms.TextBox txbCommandsAppointment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditDetails;
    }
}