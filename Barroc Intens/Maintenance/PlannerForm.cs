using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens.Maintenance
{
    public partial class PlannerForm : Form
    {
        private AppDbContext dbContext;

        public PlannerForm()
        {
            InitializeComponent();

            
        }

        private void PlannerForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.MaintenanceAppointments.Include(ma => ma.Company).Load();
            this.maintenanceAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();

            
            //var maintenanceAppointmentsCount = dbContext.MaintenanceAppointments.Where(ma => ma.appointmentFinished == true).Count();
            
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
            var selectedAppointment = (MaintenanceAppointment)dataGridView1.CurrentRow.DataBoundItem;
            txbCommandsAppointment.Text = selectedAppointment.Remark;
            //show the location of the current selected appointment
            txbCompanyLocation.Text = selectedAppointment.Company.City;

        }

        private void mcMaintanence_DateSelected(object sender, DateRangeEventArgs e)
        {
            // show all appointments on the selected date
            var selectedDate = mcMaintanence.SelectionStart;
            var selectedAppointments = dbContext.MaintenanceAppointments.Where(ma => ma.AppointmentDate == selectedDate).ToList();
            dgvPlannedAppointments.DataSource = selectedAppointments;
            

        }
    }
}
