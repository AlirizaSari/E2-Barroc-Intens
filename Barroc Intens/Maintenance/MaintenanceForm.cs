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
    public partial class MaintenanceForm : Form
    {
        private AppDbContext dbContext;

        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.MaintenanceAppointments.Load();

            this.dbContext.Companies.Load();

            this.maintenanceAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();

        }

        private void dgvMaintenanceAppointment_SelectionChanged(object sender, EventArgs e)
        {

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
    }
}
