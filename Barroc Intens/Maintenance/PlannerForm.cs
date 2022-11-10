//using Microsoft.Exchange.WebServices.Data;
using Barroc_Intens.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Barroc_Intens.Maintenance
{
    public partial class PlannerForm : Form
    {
        private AppDbContext dbContext;
        private MaintenanceAppointment _appointment;

        public PlannerForm()
        {
            InitializeComponent();
        }

        private void PlannerForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            // the code below will make it possible to look into the company table
            this.dbContext.MaintenanceAppointments.Include(ma => ma.Company).Load();
            this.maintenanceAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();
            
            this.dbContext.PlannedAppointment.Load();
            this.plannedAppointmentBindingSource.DataSource = dbContext.PlannedAppointment.Local.ToBindingList();
            
            this.dbContext.Users.Load();
            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();

            lblCurrentNumberOfOpenTickets.Text = dbContext.MaintenanceAppointments.Where(ma => ma.AppointmentIsPlanned == true).Count().ToString();

            
            

            

        }

        private void btnBackToMaintenance_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardMaintenanceForm());
        }
        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //when a date is selected show only the planned appointments of that date
            if (dgvPlannedAppointments.SelectedRows.Count > 0)
            {
                var selectedDate = (DateTime)dgvPlannedAppointments.SelectedRows[0].Cells[0].Value;
                this.plannedAppointmentBindingSource.DataSource = dbContext.PlannedAppointment.Where(pa => pa.AppointmentDate == selectedDate).ToList();
            }


        }

        private void mcMaintanence_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.plannedAppointmentBindingSource.DataSource = dbContext.PlannedAppointment.Where(pa => pa.AppointmentDate == mcMaintanence.SelectionStart).ToList();
            lblSelectedDate.Text = mcMaintanence.SelectionStart.ToShortDateString().ToString();


        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
        var selectedAppointment = (MaintenanceAppointment)dgvNewAppointments.CurrentRow.DataBoundItem;
            
        //select the current appointment selected in 

            //this will add the selected appoint to the planned appointment table
            var appointment = new PlannedAppointment()
            {
                AppointmentDate = mcMaintanence.SelectionStart,
                AppointmentTime = mcMaintanence.SelectionStart.ToLocalTime(),
                AppointmentDuration = txbVisitDuration.Text,
                AssignedEmployee = cbEmployeeAsigned.Text,
                UserId = UserLoginInformation.LoginUserId,
                CompanyId = selectedAppointment.CompanyId,
                Company = selectedAppointment.Company
            };

            if (selectedAppointment != null)
            {
                dbContext.PlannedAppointment.Add(appointment);
                //    dbContext.PlannedAppointment.Update(newAppointment);
                dbContext.SaveChanges();
                dgvPlannedAppointments.Refresh();
            }

            // this will remove the new appointment


            dgvNewAppointments.Rows.RemoveAt(dgvNewAppointments.SelectedRows[0].Index);

            dbContext.MaintenanceAppointments.Remove(selectedAppointment);
            dbContext.SaveChanges();

            //when a date is selected show only the planned appointments of that date
            
            // highlight dates that have a appointment
            var datesWithAppointments = dbContext.PlannedAppointment.Select(pa => pa.AppointmentDate).Distinct().ToList();
            mcMaintanence.BoldedDates = datesWithAppointments.ToArray();
            mcMaintanence.UpdateBoldedDates();
            // the code below will save and refresh the database


            lblMsgAppointmentPlannend.Text = "afspraak is in geplent";
            lblMsgAppointmentPlannend.Visible = true;
            this.dgvNewAppointments.Refresh();
            lblMsgAppointmentPlannend.Visible = false;
            
            txbVisitDuration.Text = "";



        }

        private void dgvPlannedAppointments_DataMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
