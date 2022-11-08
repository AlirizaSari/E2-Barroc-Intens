//using Microsoft.Exchange.WebServices.Data;
using System;
using System.Linq;

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
            this.dbContext.MaintenanceAppointments.Include(ma => ma.Company).Load();
            this.maintenanceAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();
            lblCurrentNumberOfOpenTickets.Text = dbContext.MaintenanceAppointments.Where(ma => ma.AppointmentIsPlanned == true).Count().ToString();

            this.dbContext.Users.Load();

            //this.dbContext.Products.Load();

            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();

            //showEmployeeName();
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
            _appointment = (MaintenanceAppointment)dgvNewAppointmentsx.CurrentRow.DataBoundItem;
            txbCommandsAppointment.Text = _appointment.Remark;
            //show the location of the current selected appointment
            txbCompanyLocation.Text = _appointment.Company.City;

        }

        private void mcMaintanence_DateSelected(object sender, DateRangeEventArgs e)
        {
            // show all appointments on the selected date
            var selectedDate = mcMaintanence.SelectionStart;
            var selectedAppointments = dbContext.MaintenanceAppointments.Where(ma => ma.AppointmentDate != null).ToList();
            dgvPlannedAppointments.DataSource = selectedAppointments;



            //change the font weight of the selected date
            //when clicked on a date with appointments the font weight will be bold
            //when clicked on a date without appointments the font weight will be normal 
            // based on the existence of appointments on the selected date


            //if (selectedAppointments.Count > 0 && selectedDate == DateTime.Today.Date)
            //{
            //    mcMaintanence.BoldedDates = new DateTime[] { selectedDate };
            //}
            //else
            //{
            //    mcMaintanence.BoldedDates = new DateTime[] { };
            //}




            //foreach (var appointment in selectedAppointments)
            //{
            //    if (true)
            //    {
            //        Console.WriteLine(appointment.Company + " : " + appointment.Remark);
            //    }
            }

            // show the amount of appointments on the selected date
            //var selectedAppointmentsCount = dbContext.MaintenanceAppointments.Where(ma => ma.AppointmentDate == selectedDate).Count();
            //lblSelectedDate.Text = selectedDate.ToString("dd-MM-yyyy");
            //lblCurrentNumberOfOpenTickets.Text = selectedAppointmentsCount.ToString();
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            //select the current appointment selected in 
            //var selectedAppointment = (MaintenanceAppointment)dgvNewAppointmentsx.CurrentRow.DataBoundItem;

            ////change the appointment date to the selected date in the month calendar
            //selectedAppointment.AppointmentDate = mcMaintanence.SelectionStart;
            ////change the appointment time to the selected time in the time picker
            //selectedAppointment.AppointmentTime = dtpAppointmentTimeSet.Value;
            ////change the appointment employee to the selected employee 
            //selectedAppointment.AssignedEmployee = UserLoginInformation.LoginUserName;
            ////change the appointment duration to the selected duration in the textbox
            //selectedAppointment.AppointmentDuration = txbVisitDuration.Text;
            ////change the appointment finished to true
            //selectedAppointment.AppointmentIsPlanned = true;
            ////change empty userid to current user who is logged in and clicked create
            //selectedAppointment.UserId = UserLoginInformation.LoginUserId;


            //// the code below will save and refresh the database

            //dbContext.SaveChanges();
            //this.dgvNewAppointmentsx.Refresh();

        }

        private void dgvPlannedAppointments_DataMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
