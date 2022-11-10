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
            //show the remark of the current selected appointment
            _appointment = (MaintenanceAppointment)dgvNewAppointments.CurrentRow.DataBoundItem;
            txbCommandsAppointment.Text = _appointment.Remark;
            //show the location of the current selected appointment
            txbCompanyLocation.Text = _appointment.Company.City;

        }

        private void mcMaintanence_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.plannedAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();
            // show all appointments on the selected date
            var selectedDate = mcMaintanence.SelectionStart;
            //var selectedAppointment = dgvPlannedAppointments.DataSource.GetType();
            //if (selectedAppointment)
            //{

            //}
            //dgvPlannedAppointments.DataSource = selectedAppointments;

            


            ////change the font weight of the selected date
            ////when clicked on a date with appointments the font weight will be bold
            ////when clicked on a date without appointments the font weight will be normal 
            //// based on the existence of appointments on the selected date
            //if (selectedAppointments.Count > 0)
            //{
            //    mcMaintanence.BoldedDates = new DateTime[] { selectedDate };
            //}
            //else
            //{
            //    mcMaintanence.BoldedDates = new DateTime[] { };
            //}



            // show the amount of appointments on the selected date
            lblSelectedDate.Text = selectedDate.ToString("dd-MM-yyyy");
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            //select the current appointment selected in 
            var selectedAppointment = (MaintenanceAppointment)dgvNewAppointments.CurrentRow.DataBoundItem;

            //this will add the selected appoint to the planned appointment table
            //var newAppointment = new PlannedAppointment()
            //{
                  
            //    AppointmentDate = mcMaintanence.SelectionStart,
            //    AppointmentTime = mcMaintanence.SelectionStart.ToLocalTime(),
            //    AppointmentDuration = txbVisitDuration.Text,
            //    AssignedEmployee = cbEmployeeAsigned.Text,
            //    UserId = UserLoginInformation.LoginUserId,
            //    CompanyId = selectedAppointment.CompanyId,
            //    Company = selectedAppointment.Company
            //};
            
            //if (selectedAppointment != null)
            //{
            //    this.dbContext.PlannedAppointment.Add(newAppointment);
            //    dbContext.PlannedAppointment.Update(newAppointment);
            //    dbContext.SaveChanges();
            //    dgvPlannedAppointments.Refresh();
            //}

            // this will remove the new appointment
            

            dgvNewAppointments.Rows.RemoveAt(dgvNewAppointments.SelectedRows[0].Index);

            dbContext.MaintenanceAppointments.Remove(selectedAppointment);
            dbContext.SaveChanges();

            // the code below will save and refresh the database

            
            lblMsgAppointmentPlannend.Text = "afspraak is in geplent";
            lblMsgAppointmentPlannend.Visible = true;
            this.dgvNewAppointments.Refresh();
            lblMsgAppointmentPlannend.Visible = false;

        }

        private void dgvPlannedAppointments_DataMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
