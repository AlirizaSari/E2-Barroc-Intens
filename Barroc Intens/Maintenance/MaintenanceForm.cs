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

            this.maintenanceAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();

        }

        private void maintenanceAppointmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var maintenanceAppointment = (MaintenanceAppointment)this.maintenanceAppointmentDataGridView.CurrentRow.DataBoundItem;

            if (maintenanceAppointment == null)
                return;

            this.dbContext.Entry(maintenanceAppointment)
            .Reference(m => m.Company)
            .Load();

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Barroc_Intens.MainForm mainForm = new Barroc_Intens.MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
