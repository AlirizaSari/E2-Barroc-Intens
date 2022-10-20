using Barroc_Intens.Classes;
using Barroc_Intens.Maintenance;
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
    public partial class DashboardMaintenanceForm : Form
    {
        public DashboardMaintenanceForm()
        {
            InitializeComponent();
            lblAccountName.Text = UserLoginInformation.LoginUserName;
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.RolId);
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnMaintenancePlanner_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlannerForm plannerForm = new PlannerForm();
            plannerForm.ShowDialog();
            this.Close();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
            this.Close();
        }
    }
}
