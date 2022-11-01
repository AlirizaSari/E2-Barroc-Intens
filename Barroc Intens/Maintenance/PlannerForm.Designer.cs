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
            this.components = new System.ComponentModel.Container();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnBackToMaintenance = new System.Windows.Forms.Button();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlCalander = new System.Windows.Forms.Panel();
            this.lblCurrentNumberOfFinishedTickets = new System.Windows.Forms.Label();
            this.lblFinishedticketCounter = new System.Windows.Forms.Label();
            this.lblCurrentNumberOfOpenTickets = new System.Windows.Forms.Label();
            this.lblOpenMaintenceTicketsCounter = new System.Windows.Forms.Label();
            this.lblCalanderHeader = new System.Windows.Forms.Label();
            this.mcMaintanence = new System.Windows.Forms.MonthCalendar();
            this.pnlAppointmentList = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbxCompanyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbxLocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbxEmployeeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSelectedDateTitle = new System.Windows.Forms.Label();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.lblAppointmentListHeader = new System.Windows.Forms.Label();
            this.pnlAppointmentDetails = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.lblCompanyAdres = new System.Windows.Forms.Label();
            this.lblEmployeeHeader = new System.Windows.Forms.Label();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.txbCommandsAppointment = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCommentsCompanyHeader = new System.Windows.Forms.Label();
            this.lblDateAddedHeader = new System.Windows.Forms.Label();
            this.lblCompanyCityHeader = new System.Windows.Forms.Label();
            this.lblCompanyAdresHeader = new System.Windows.Forms.Label();
            this.lblDetailsHeader = new System.Windows.Forms.Label();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlCalander.SuspendLayout();
            this.pnlAppointmentList.SuspendLayout();
            this.pnlAppointmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
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
            this.btnBackToMaintenance.Location = new System.Drawing.Point(1656, 16);
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
            this.pnlTopMenu.Size = new System.Drawing.Size(1837, 142);
            this.pnlTopMenu.TabIndex = 4;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(713, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(392, 46);
            this.lblFormTitle.TabIndex = 3;
            this.lblFormTitle.Text = "onderhouds planner";
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
            this.pnlCalander.Size = new System.Drawing.Size(401, 649);
            this.pnlCalander.TabIndex = 5;
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
            // mcMaintanence
            // 
            this.mcMaintanence.Location = new System.Drawing.Point(72, 63);
            this.mcMaintanence.Name = "mcMaintanence";
            this.mcMaintanence.TabIndex = 0;
            // 
            // pnlAppointmentList
            // 
            this.pnlAppointmentList.Controls.Add(this.listView1);
            this.pnlAppointmentList.Controls.Add(this.lblSelectedDateTitle);
            this.pnlAppointmentList.Controls.Add(this.lblSelectedDate);
            this.pnlAppointmentList.Controls.Add(this.lblAppointmentListHeader);
            this.pnlAppointmentList.Location = new System.Drawing.Point(437, 145);
            this.pnlAppointmentList.Name = "pnlAppointmentList";
            this.pnlAppointmentList.Size = new System.Drawing.Size(416, 649);
            this.pnlAppointmentList.TabIndex = 6;
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
            this.listView1.Size = new System.Drawing.Size(382, 529);
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
            // pnlAppointmentDetails
            // 
            this.pnlAppointmentDetails.Controls.Add(this.button1);
            this.pnlAppointmentDetails.Controls.Add(this.lblEmployee);
            this.pnlAppointmentDetails.Controls.Add(this.lblDateAdded);
            this.pnlAppointmentDetails.Controls.Add(this.lblCompanyCity);
            this.pnlAppointmentDetails.Controls.Add(this.lblCompanyAdres);
            this.pnlAppointmentDetails.Controls.Add(this.lblEmployeeHeader);
            this.pnlAppointmentDetails.Controls.Add(this.btnNewAppointment);
            this.pnlAppointmentDetails.Controls.Add(this.btnEditDetails);
            this.pnlAppointmentDetails.Controls.Add(this.txbCommandsAppointment);
            this.pnlAppointmentDetails.Controls.Add(this.lblCompanyName);
            this.pnlAppointmentDetails.Controls.Add(this.lblCommentsCompanyHeader);
            this.pnlAppointmentDetails.Controls.Add(this.lblDateAddedHeader);
            this.pnlAppointmentDetails.Controls.Add(this.lblCompanyCityHeader);
            this.pnlAppointmentDetails.Controls.Add(this.lblCompanyAdresHeader);
            this.pnlAppointmentDetails.Controls.Add(this.lblDetailsHeader);
            this.pnlAppointmentDetails.Location = new System.Drawing.Point(859, 144);
            this.pnlAppointmentDetails.Name = "pnlAppointmentDetails";
            this.pnlAppointmentDetails.Size = new System.Drawing.Size(401, 650);
            this.pnlAppointmentDetails.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "edit details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(136, 231);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(124, 17);
            this.lblEmployee.TabIndex = 14;
            this.lblEmployee.Text = "naam medewerker";
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(216, 187);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(82, 17);
            this.lblDateAdded.TabIndex = 13;
            this.lblDateAdded.Text = "dd/mm/yyyy";
            // 
            // lblCompanyCity
            // 
            this.lblCompanyCity.AutoSize = true;
            this.lblCompanyCity.Location = new System.Drawing.Point(92, 148);
            this.lblCompanyCity.Name = "lblCompanyCity";
            this.lblCompanyCity.Size = new System.Drawing.Size(107, 17);
            this.lblCompanyCity.TabIndex = 12;
            this.lblCompanyCity.Text = "vestegings stad";
            // 
            // lblCompanyAdres
            // 
            this.lblCompanyAdres.AutoSize = true;
            this.lblCompanyAdres.Location = new System.Drawing.Point(92, 109);
            this.lblCompanyAdres.Name = "lblCompanyAdres";
            this.lblCompanyAdres.Size = new System.Drawing.Size(138, 17);
            this.lblCompanyAdres.TabIndex = 11;
            this.lblCompanyAdres.Text = "adres van het bedrijf";
            // 
            // lblEmployeeHeader
            // 
            this.lblEmployeeHeader.AutoSize = true;
            this.lblEmployeeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeHeader.Location = new System.Drawing.Point(30, 231);
            this.lblEmployeeHeader.Name = "lblEmployeeHeader";
            this.lblEmployeeHeader.Size = new System.Drawing.Size(100, 17);
            this.lblEmployeeHeader.TabIndex = 10;
            this.lblEmployeeHeader.Text = "medewerker:";
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(33, 462);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(103, 49);
            this.btnNewAppointment.TabIndex = 8;
            this.btnNewAppointment.Text = "nieuwe afspraak";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(159, 462);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(103, 49);
            this.btnEditDetails.TabIndex = 7;
            this.btnEditDetails.Text = "edit details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
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
            // lblCommentsCompanyHeader
            // 
            this.lblCommentsCompanyHeader.AutoSize = true;
            this.lblCommentsCompanyHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentsCompanyHeader.Location = new System.Drawing.Point(30, 274);
            this.lblCommentsCompanyHeader.Name = "lblCommentsCompanyHeader";
            this.lblCommentsCompanyHeader.Size = new System.Drawing.Size(106, 17);
            this.lblCommentsCompanyHeader.TabIndex = 4;
            this.lblCommentsCompanyHeader.Text = "opmerkingen:";
            // 
            // lblDateAddedHeader
            // 
            this.lblDateAddedHeader.AutoSize = true;
            this.lblDateAddedHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAddedHeader.Location = new System.Drawing.Point(30, 187);
            this.lblDateAddedHeader.Name = "lblDateAddedHeader";
            this.lblDateAddedHeader.Size = new System.Drawing.Size(180, 17);
            this.lblDateAddedHeader.TabIndex = 3;
            this.lblDateAddedHeader.Text = "afspraak toegevoed op:";
            // 
            // lblCompanyCityHeader
            // 
            this.lblCompanyCityHeader.AutoSize = true;
            this.lblCompanyCityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyCityHeader.Location = new System.Drawing.Point(30, 148);
            this.lblCompanyCityHeader.Name = "lblCompanyCityHeader";
            this.lblCompanyCityHeader.Size = new System.Drawing.Size(46, 17);
            this.lblCompanyCityHeader.TabIndex = 2;
            this.lblCompanyCityHeader.Text = "Stad:";
            // 
            // lblCompanyAdresHeader
            // 
            this.lblCompanyAdresHeader.AutoSize = true;
            this.lblCompanyAdresHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAdresHeader.Location = new System.Drawing.Point(30, 109);
            this.lblCompanyAdresHeader.Name = "lblCompanyAdresHeader";
            this.lblCompanyAdresHeader.Size = new System.Drawing.Size(55, 17);
            this.lblCompanyAdresHeader.TabIndex = 1;
            this.lblCompanyAdresHeader.Text = "Adres:";
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
            // maintenanceAppointmentBindingSource
            // 
            this.maintenanceAppointmentBindingSource.DataSource = typeof(Barroc_Intens.MaintenanceAppointment);
            // 
            // PlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 806);
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
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblCompanyAdresHeader;
        private System.Windows.Forms.Label lblDetailsHeader;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCommentsCompanyHeader;
        private System.Windows.Forms.Label lblDateAddedHeader;
        private System.Windows.Forms.Label lblCompanyCityHeader;
        private System.Windows.Forms.TextBox txbCommandsAppointment;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Label lblEmployeeHeader;
        private System.Windows.Forms.Label lblCompanyAdres;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
    }
}