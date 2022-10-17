using Barroc_Intens.Finances;
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

namespace Barroc_Intens
{
    public partial class MainForm : Form
    {
        private AppDbContext dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void btnDirectToFinances_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardFinanceForm dashboardFinanceForm = new DashboardFinanceForm();
            dashboardFinanceForm.ShowDialog();
            this.Close();
        }

        private void btnDirectToSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales.CustomerNotesForm CustomerNotesForm = new Sales.CustomerNotesForm();
            CustomerNotesForm.ShowDialog();
            this.Close();
        }

        private void btnDirectToMaintenance_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMaintenanceForm dashboardMaintenanceForm = new DashboardMaintenanceForm();
            dashboardMaintenanceForm.ShowDialog();
            this.Close();
        }

        private void btnDirectToInkoop_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardInkoopForm dashboardInkoopForm = new DashboardInkoopForm();
            dashboardInkoopForm.ShowDialog();
            this.Close();
        }
    }
}
