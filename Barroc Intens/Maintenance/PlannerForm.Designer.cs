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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlannerForm));
            this.btnBackToMaintenance = new System.Windows.Forms.Button();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlCalander = new System.Windows.Forms.Panel();
            this.lblErrorMsgNoAppointments = new System.Windows.Forms.Label();
            this.lblMsgAppointmentPlannend = new System.Windows.Forms.Label();
            this.dtpAppointmentTimeSet = new System.Windows.Forms.DateTimePicker();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.txbVisitDuration = new System.Windows.Forms.TextBox();
            this.lblCurrentNumberOfOpenTickets = new System.Windows.Forms.Label();
            this.cbEmployeeAsigned = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOpenMaintenceTicketsCounter = new System.Windows.Forms.Label();
            this.lblVisitDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.lblCalanderHeader = new System.Windows.Forms.Label();
            this.mcMaintanence = new System.Windows.Forms.MonthCalendar();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAppointmentList = new System.Windows.Forms.Panel();
            this.dgvPlannedAppointments = new System.Windows.Forms.DataGridView();
            this.companyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectedDateTitle = new System.Windows.Forms.Label();
            this.lblAppointmentListHeader = new System.Windows.Forms.Label();
            this.pnlAppointmentDetails = new System.Windows.Forms.Panel();
            this.txbCompanyLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNewAppointments = new System.Windows.Forms.DataGridView();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRoutineAppointmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfoTextNewAppointment = new System.Windows.Forms.Label();
            this.lblSectionNewAppointmentsHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.txbCommandsAppointment = new System.Windows.Forms.TextBox();
            this.lblCommentsCompanyHeader = new System.Windows.Forms.Label();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlCalander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
            this.pnlAppointmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlannedAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedAppointmentBindingSource)).BeginInit();
            this.pnlAppointmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAppointments)).BeginInit();
            this.SuspendLayout();
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
            this.pnlCalander.Controls.Add(this.lblErrorMsgNoAppointments);
            this.pnlCalander.Controls.Add(this.lblMsgAppointmentPlannend);
            this.pnlCalander.Controls.Add(this.dtpAppointmentTimeSet);
            this.pnlCalander.Controls.Add(this.btnCreateAppointment);
            this.pnlCalander.Controls.Add(this.txbVisitDuration);
            this.pnlCalander.Controls.Add(this.lblCurrentNumberOfOpenTickets);
            this.pnlCalander.Controls.Add(this.cbEmployeeAsigned);
            this.pnlCalander.Controls.Add(this.lblOpenMaintenceTicketsCounter);
            this.pnlCalander.Controls.Add(this.lblVisitDuration);
            this.pnlCalander.Controls.Add(this.label3);
            this.pnlCalander.Controls.Add(this.lblAppointmentTime);
            this.pnlCalander.Controls.Add(this.lblCalanderHeader);
            this.pnlCalander.Controls.Add(this.mcMaintanence);
            this.pnlCalander.Controls.Add(this.lblSelectedDate);
            this.pnlCalander.Location = new System.Drawing.Point(615, 146);
            this.pnlCalander.Name = "pnlCalander";
            this.pnlCalander.Size = new System.Drawing.Size(378, 719);
            this.pnlCalander.TabIndex = 5;
            // 
            // lblErrorMsgNoAppointments
            // 
            this.lblErrorMsgNoAppointments.AutoSize = true;
            this.lblErrorMsgNoAppointments.Location = new System.Drawing.Point(65, 569);
            this.lblErrorMsgNoAppointments.Name = "lblErrorMsgNoAppointments";
            this.lblErrorMsgNoAppointments.Size = new System.Drawing.Size(64, 16);
            this.lblErrorMsgNoAppointments.TabIndex = 23;
            this.lblErrorMsgNoAppointments.Text = "error msg";
            this.lblErrorMsgNoAppointments.Visible = false;
            // 
            // lblMsgAppointmentPlannend
            // 
            this.lblMsgAppointmentPlannend.AutoSize = true;
            this.lblMsgAppointmentPlannend.Location = new System.Drawing.Point(264, 479);
            this.lblMsgAppointmentPlannend.Name = "lblMsgAppointmentPlannend";
            this.lblMsgAppointmentPlannend.Size = new System.Drawing.Size(0, 16);
            this.lblMsgAppointmentPlannend.TabIndex = 22;
            this.lblMsgAppointmentPlannend.Visible = false;
            // 
            // dtpAppointmentTimeSet
            // 
            this.dtpAppointmentTimeSet.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppointmentTimeSet.Location = new System.Drawing.Point(118, 359);
            this.dtpAppointmentTimeSet.Name = "dtpAppointmentTimeSet";
            this.dtpAppointmentTimeSet.ShowUpDown = true;
            this.dtpAppointmentTimeSet.Size = new System.Drawing.Size(230, 22);
            this.dtpAppointmentTimeSet.TabIndex = 11;
            this.dtpAppointmentTimeSet.Value = new System.DateTime(2022, 11, 6, 9, 27, 0, 0);
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Location = new System.Drawing.Point(118, 499);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(158, 63);
            this.btnCreateAppointment.TabIndex = 10;
            this.btnCreateAppointment.Text = "Inplannen";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;

            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // txbVisitDuration
            // 
            this.txbVisitDuration.Location = new System.Drawing.Point(117, 447);
            this.txbVisitDuration.Name = "txbVisitDuration";
            this.txbVisitDuration.Size = new System.Drawing.Size(230, 22);
            this.txbVisitDuration.TabIndex = 9;
            // 
            // lblCurrentNumberOfOpenTickets
            // 
            this.lblCurrentNumberOfOpenTickets.AutoSize = true;
            this.lblCurrentNumberOfOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNumberOfOpenTickets.Location = new System.Drawing.Point(60, 643);
            this.lblCurrentNumberOfOpenTickets.Name = "lblCurrentNumberOfOpenTickets";
            this.lblCurrentNumberOfOpenTickets.Size = new System.Drawing.Size(105, 20);
            this.lblCurrentNumberOfOpenTickets.TabIndex = 3;
            this.lblCurrentNumberOfOpenTickets.Text = "(x) bezoeken";
            // 
            // cbEmployeeAsigned
            // 
            this.cbEmployeeAsigned.DataSource = this.userBindingSource;
            this.cbEmployeeAsigned.DisplayMember = "Name";
            this.cbEmployeeAsigned.FormattingEnabled = true;
            this.cbEmployeeAsigned.Location = new System.Drawing.Point(118, 404);
            this.cbEmployeeAsigned.Name = "cbEmployeeAsigned";
            this.cbEmployeeAsigned.Size = new System.Drawing.Size(230, 24);
            this.cbEmployeeAsigned.TabIndex = 8;
            this.cbEmployeeAsigned.ValueMember = "UserId";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Barroc_Intens.User);
            // 
            // lblOpenMaintenceTicketsCounter
            // 
            this.lblOpenMaintenceTicketsCounter.AutoSize = true;
            this.lblOpenMaintenceTicketsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenMaintenceTicketsCounter.Location = new System.Drawing.Point(61, 626);
            this.lblOpenMaintenceTicketsCounter.Name = "lblOpenMaintenceTicketsCounter";
            this.lblOpenMaintenceTicketsCounter.Size = new System.Drawing.Size(274, 16);
            this.lblOpenMaintenceTicketsCounter.TabIndex = 2;
            this.lblOpenMaintenceTicketsCounter.Text = "openstaande bezoeken voor vandaag:";
            // 
            // lblVisitDuration
            // 
            this.lblVisitDuration.AutoSize = true;
            this.lblVisitDuration.Location = new System.Drawing.Point(16, 450);
            this.lblVisitDuration.Name = "lblVisitDuration";
            this.lblVisitDuration.Size = new System.Drawing.Size(85, 16);
            this.lblVisitDuration.TabIndex = 5;
            this.lblVisitDuration.Text = "Bezoek duur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medewerker:";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(18, 364);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(84, 16);
            this.lblAppointmentTime.TabIndex = 2;
            this.lblAppointmentTime.Text = "Afspraak tijd:";
            // 
            // lblCalanderHeader
            // 
            this.lblCalanderHeader.AutoSize = true;
            this.lblCalanderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalanderHeader.Location = new System.Drawing.Point(113, 15);
            this.lblCalanderHeader.Name = "lblCalanderHeader";
            this.lblCalanderHeader.Size = new System.Drawing.Size(172, 40);
            this.lblCalanderHeader.TabIndex = 1;
            this.lblCalanderHeader.Text = "kalender\r\ndag / week /maand ";
            this.lblCalanderHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mcMaintanence
            // 
            this.mcMaintanence.Location = new System.Drawing.Point(68, 64);
            this.mcMaintanence.Name = "mcMaintanence";
            this.mcMaintanence.TabIndex = 0;
            this.mcMaintanence.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcMaintanence_DateSelected);
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.Location = new System.Drawing.Point(147, 310);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(113, 20);
            this.lblSelectedDate.TabIndex = 1;
            this.lblSelectedDate.Text = "DD/MM/YYYY";
            // 
            // maintenanceAppointmentBindingSource
            // 
            this.maintenanceAppointmentBindingSource.DataSource = typeof(Barroc_Intens.MaintenanceAppointment);
            // 
            // pnlAppointmentList
            // 
            this.pnlAppointmentList.Controls.Add(this.dgvPlannedAppointments);
            this.pnlAppointmentList.Controls.Add(this.lblSelectedDateTitle);
            this.pnlAppointmentList.Controls.Add(this.lblAppointmentListHeader);
            this.pnlAppointmentList.Location = new System.Drawing.Point(999, 144);
            this.pnlAppointmentList.Name = "pnlAppointmentList";
            this.pnlAppointmentList.Size = new System.Drawing.Size(796, 719);
            this.pnlAppointmentList.TabIndex = 6;
            // 
            // dgvPlannedAppointments
            // 
            this.dgvPlannedAppointments.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlannedAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlannedAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlannedAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn1,
            this.AppointmentDate,
            this.AppointmentTime,
            this.AppointmentDuration,
            this.AssignedEmployee,
            this.userDataGridViewTextBoxColumn});
            this.dgvPlannedAppointments.DataSource = this.plannedAppointmentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlannedAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlannedAppointments.Location = new System.Drawing.Point(12, 70);
            this.dgvPlannedAppointments.Name = "dgvPlannedAppointments";
            this.dgvPlannedAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlannedAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlannedAppointments.RowHeadersVisible = false;
            this.dgvPlannedAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPlannedAppointments.RowTemplate.Height = 24;
            this.dgvPlannedAppointments.Size = new System.Drawing.Size(781, 648);
            this.dgvPlannedAppointments.TabIndex = 21;
            this.dgvPlannedAppointments.DataMemberChanged += new System.EventHandler(this.dgvPlannedAppointments_DataMemberChanged);
            // 
            // companyDataGridViewTextBoxColumn1
            // 
            this.companyDataGridViewTextBoxColumn1.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn1.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn1.Name = "companyDataGridViewTextBoxColumn1";
            this.companyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn1.Width = 125;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.HeaderText = "AppointmentDate";
            this.AppointmentDate.MinimumWidth = 6;
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            this.AppointmentDate.Width = 125;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.DataPropertyName = "AppointmentTime";
            this.AppointmentTime.HeaderText = "AppointmentTime";
            this.AppointmentTime.MinimumWidth = 6;
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.ReadOnly = true;
            this.AppointmentTime.Width = 125;
            // 
            // AppointmentDuration
            // 
            this.AppointmentDuration.DataPropertyName = "AppointmentDuration";
            this.AppointmentDuration.HeaderText = "AppointmentDuration";
            this.AppointmentDuration.MinimumWidth = 6;
            this.AppointmentDuration.Name = "AppointmentDuration";
            this.AppointmentDuration.ReadOnly = true;
            this.AppointmentDuration.Width = 125;
            // 
            // AssignedEmployee
            // 
            this.AssignedEmployee.DataPropertyName = "AssignedEmployee";
            this.AssignedEmployee.HeaderText = "AssignedEmployee";
            this.AssignedEmployee.MinimumWidth = 6;
            this.AssignedEmployee.Name = "AssignedEmployee";
            this.AssignedEmployee.ReadOnly = true;
            this.AssignedEmployee.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Width = 125;
            // 
            // plannedAppointmentBindingSource
            // 
            this.plannedAppointmentBindingSource.DataSource = typeof(Barroc_Intens.Classes.PlannedAppointment);
            // 
            // lblSelectedDateTitle
            // 
            this.lblSelectedDateTitle.AutoSize = true;
            this.lblSelectedDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDateTitle.Location = new System.Drawing.Point(18, 40);
            this.lblSelectedDateTitle.Name = "lblSelectedDateTitle";
            this.lblSelectedDateTitle.Size = new System.Drawing.Size(170, 20);
            this.lblSelectedDateTitle.TabIndex = 2;
            this.lblSelectedDateTitle.Text = "geselecteerde datum:";
            // 
            // lblAppointmentListHeader
            // 
            this.lblAppointmentListHeader.AutoSize = true;
            this.lblAppointmentListHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentListHeader.Location = new System.Drawing.Point(187, 10);
            this.lblAppointmentListHeader.Name = "lblAppointmentListHeader";
            this.lblAppointmentListHeader.Size = new System.Drawing.Size(231, 20);
            this.lblAppointmentListHeader.TabIndex = 0;
            this.lblAppointmentListHeader.Text = "onderhouds afspraken lijst";
            this.lblAppointmentListHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlAppointmentDetails
            // 
            this.pnlAppointmentDetails.Controls.Add(this.txbCompanyLocation);
            this.pnlAppointmentDetails.Controls.Add(this.label1);
            this.pnlAppointmentDetails.Controls.Add(this.dgvNewAppointments);
            this.pnlAppointmentDetails.Controls.Add(this.lblInfoTextNewAppointment);
            this.pnlAppointmentDetails.Controls.Add(this.lblSectionNewAppointmentsHeader);
            this.pnlAppointmentDetails.Controls.Add(this.button1);
            this.pnlAppointmentDetails.Controls.Add(this.btnNewAppointment);
            this.pnlAppointmentDetails.Controls.Add(this.btnEditDetails);
            this.pnlAppointmentDetails.Controls.Add(this.txbCommandsAppointment);
            this.pnlAppointmentDetails.Controls.Add(this.lblCommentsCompanyHeader);
            this.pnlAppointmentDetails.Location = new System.Drawing.Point(24, 144);
            this.pnlAppointmentDetails.Name = "pnlAppointmentDetails";
            this.pnlAppointmentDetails.Size = new System.Drawing.Size(585, 715);
            this.pnlAppointmentDetails.TabIndex = 7;
            // 
            // txbCompanyLocation
            // 
            this.txbCompanyLocation.Location = new System.Drawing.Point(166, 448);
            this.txbCompanyLocation.Multiline = true;
            this.txbCompanyLocation.Name = "txbCompanyLocation";
            this.txbCompanyLocation.ReadOnly = true;
            this.txbCompanyLocation.Size = new System.Drawing.Size(353, 22);
            this.txbCompanyLocation.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Locatie:";
            // 
            // dgvNewAppointments
            // 
            this.dgvNewAppointments.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.isRoutineAppointmentDataGridViewCheckBoxColumn,
            this.Added});
            this.dgvNewAppointments.DataSource = this.maintenanceAppointmentBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNewAppointments.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNewAppointments.Location = new System.Drawing.Point(6, 86);
            this.dgvNewAppointments.Name = "dgvNewAppointments";
            this.dgvNewAppointments.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNewAppointments.RowHeadersVisible = false;
            this.dgvNewAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvNewAppointments.RowTemplate.Height = 24;
            this.dgvNewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewAppointments.Size = new System.Drawing.Size(568, 349);
            this.dgvNewAppointments.TabIndex = 19;
            this.dgvNewAppointments.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // isRoutineAppointmentDataGridViewCheckBoxColumn
            // 
            this.isRoutineAppointmentDataGridViewCheckBoxColumn.DataPropertyName = "IsRoutineAppointment";
            this.isRoutineAppointmentDataGridViewCheckBoxColumn.HeaderText = "IsRoutineAppointment";
            this.isRoutineAppointmentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isRoutineAppointmentDataGridViewCheckBoxColumn.Name = "isRoutineAppointmentDataGridViewCheckBoxColumn";
            this.isRoutineAppointmentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isRoutineAppointmentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Added
            // 
            this.Added.DataPropertyName = "Added";
            this.Added.HeaderText = "Added";
            this.Added.MinimumWidth = 6;
            this.Added.Name = "Added";
            this.Added.ReadOnly = true;
            this.Added.Width = 125;
            // 
            // lblInfoTextNewAppointment
            // 
            this.lblInfoTextNewAppointment.AutoSize = true;
            this.lblInfoTextNewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTextNewAppointment.Location = new System.Drawing.Point(3, 66);
            this.lblInfoTextNewAppointment.Name = "lblInfoTextNewAppointment";
            this.lblInfoTextNewAppointment.Size = new System.Drawing.Size(275, 16);
            this.lblInfoTextNewAppointment.TabIndex = 18;
            this.lblInfoTextNewAppointment.Text = "Selecteer een nieuwe onderhouds aanvraag:";
            // 
            // lblSectionNewAppointmentsHeader
            // 
            this.lblSectionNewAppointmentsHeader.AutoSize = true;
            this.lblSectionNewAppointmentsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionNewAppointmentsHeader.Location = new System.Drawing.Point(131, 10);
            this.lblSectionNewAppointmentsHeader.Name = "lblSectionNewAppointmentsHeader";
            this.lblSectionNewAppointmentsHeader.Size = new System.Drawing.Size(311, 20);
            this.lblSectionNewAppointmentsHeader.TabIndex = 17;
            this.lblSectionNewAppointmentsHeader.Text = "Binnengekomen afspraak aanvragen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "edit details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(57, 627);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(103, 46);
            this.btnNewAppointment.TabIndex = 8;
            this.btnNewAppointment.Text = "nieuwe afspraak";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(229, 627);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(103, 46);
            this.btnEditDetails.TabIndex = 7;
            this.btnEditDetails.Text = "edit details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            // 
            // txbCommandsAppointment
            // 
            this.txbCommandsAppointment.Location = new System.Drawing.Point(57, 500);
            this.txbCommandsAppointment.Multiline = true;
            this.txbCommandsAppointment.Name = "txbCommandsAppointment";
            this.txbCommandsAppointment.ReadOnly = true;
            this.txbCommandsAppointment.Size = new System.Drawing.Size(462, 116);
            this.txbCommandsAppointment.TabIndex = 6;
            // 
            // lblCommentsCompanyHeader
            // 
            this.lblCommentsCompanyHeader.AutoSize = true;
            this.lblCommentsCompanyHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentsCompanyHeader.Location = new System.Drawing.Point(59, 481);
            this.lblCommentsCompanyHeader.Name = "lblCommentsCompanyHeader";
            this.lblCommentsCompanyHeader.Size = new System.Drawing.Size(101, 16);
            this.lblCommentsCompanyHeader.TabIndex = 4;
            this.lblCommentsCompanyHeader.Text = "opmerkingen:";
            // 
            // PlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 867);
            this.Controls.Add(this.pnlCalander);
            this.Controls.Add(this.pnlAppointmentDetails);
            this.Controls.Add(this.pnlAppointmentList);
            this.Controls.Add(this.pnlTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlannerForm";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlannerForm_Load);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlCalander.ResumeLayout(false);
            this.pnlCalander.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
            this.pnlAppointmentList.ResumeLayout(false);
            this.pnlAppointmentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlannedAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedAppointmentBindingSource)).EndInit();
            this.pnlAppointmentDetails.ResumeLayout(false);
            this.pnlAppointmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackToMaintenance;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel pnlCalander;
        private System.Windows.Forms.Panel pnlAppointmentList;
        private System.Windows.Forms.Panel pnlAppointmentDetails;
        private System.Windows.Forms.Label lblCalanderHeader;
        private System.Windows.Forms.MonthCalendar mcMaintanence;
        private System.Windows.Forms.Label lblSelectedDateTitle;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Label lblAppointmentListHeader;
        private System.Windows.Forms.Label lblCommentsCompanyHeader;
        private System.Windows.Forms.TextBox txbCommandsAppointment;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.TextBox txbVisitDuration;
        private System.Windows.Forms.Label lblCurrentNumberOfOpenTickets;
        private System.Windows.Forms.ComboBox cbEmployeeAsigned;
        private System.Windows.Forms.Label lblOpenMaintenceTicketsCounter;
        private System.Windows.Forms.Label lblVisitDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblInfoTextNewAppointment;
        private System.Windows.Forms.Label lblSectionNewAppointmentsHeader;
        private System.Windows.Forms.DataGridView dgvPlannedAppointments;
        private System.Windows.Forms.DataGridView dgvNewAppointments;
        private System.Windows.Forms.TextBox txbCompanyLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn appointmentFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTimeSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMsgAppointmentPlannend;
        private System.Windows.Forms.BindingSource plannedAppointmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRoutineAppointmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Added;
        private System.Windows.Forms.Label lblErrorMsgNoAppointments;
    }
}