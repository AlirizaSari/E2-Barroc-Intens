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
        private int _recordCount;

        public PlannerForm()
        {
            InitializeComponent();

            
        }

        private void PlannerForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.MaintenanceAppointments.Load();
            this.maintenanceAppointmentBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();

            string maintenanceAppointmentsCount = dbContext.MaintenanceAppointments.Count().ToString();

            lblCurrentNumberOfOpenTickets.Text = maintenanceAppointmentsCount;




            //DateTime today = DateTime.Today;

            //DateTime[] dates = { today.AddDays(1),
            //today.AddDays(3), today.AddDays(5)};

            //mcMaintanence.BoldedDates = dates;

            //for (int r = 0; r < dates.GetLength(0); r++)
            //{
            //    DataGridViewRow gridView = new DataGridViewRow();
            //    gridView.CreateCells(bsMaintenanceAppointmentData);

            //    for (int c = 0; c < dates.GetLength(1); c++)
            //    {
            //        gridView.CreateCells[c].Value = dates;
            //    }
            //}
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
