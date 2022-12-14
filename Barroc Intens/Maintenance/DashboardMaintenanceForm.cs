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
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.LoginRolId);

            if (UserLoginInformation.LoginRolId != 1)
            {
                pboxLogo.Visible = false;
                btnBackToMain.Visible = false;
                btnMaintenance.Location = new Point(40, 117);
                btnMaintenancePlanner.Location = new Point(264, 117);
            }
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardAdminForm());
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardAdminForm());
        }

        private void btnMaintenancePlanner_Click(object sender, EventArgs e)
        {
            DirectToForm(new PlannerForm());
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            DirectToForm(new MaintenanceForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DirectToForm(new InlogForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnPartsForm_Click(object sender, EventArgs e)
        {
            DirectToForm(new PartsForm());
        }
    }
}
