using Barroc_Intens.Classes;
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
    public partial class DashboardAdminForm : Form
    {
        private AppDbContext dbContext;

        public DashboardAdminForm()
        {
            InitializeComponent();
            lblAccountName.Text = UserLoginInformation.LoginUserName;
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.LoginRolId);
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
        }

        private void DashboardAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void btnDirectToFinances_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void btnDirectToMarketing_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }

        private void btnDirectToMaintenance_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardMaintenanceForm());
        }

        private void btnDirectToSales_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardSalesForm());
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

    }
}
