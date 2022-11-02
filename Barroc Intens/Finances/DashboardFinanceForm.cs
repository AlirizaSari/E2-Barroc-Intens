using Barroc_Intens.Classes;
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
    public partial class DashboardFinanceForm : Form
    {
        private AppDbContext dbContext;
        public DashboardFinanceForm()
        {
            InitializeComponent();
            lblAccountName.Text = UserLoginInformation.LoginUserName;
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.LoginRolId);
            
            if (UserLoginInformation.LoginRolId != 1)
            {
                pboxLogo.Visible = false;
                btnBackToMain.Visible = false;
                btnDirectToInvoice.Location = new Point(46, 117);
                btnDirectToLeaseContract.Location = new Point(279, 117);
            }
        }

        private void btnDirectToInvoice_Click(object sender, EventArgs e)
        {
            DirectToForm(new InvoiceForm());
        }

        /// <summary>
        /// If you click on the logo, you will be redirected to the homepage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxLogo_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardAdminForm());
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardAdminForm());
        }

        private void DashboardFinanceForm_Load(object sender, EventArgs e)
        {
            txbExtraInfo.Text = "Dit is een test";

            this.dbContext = new AppDbContext();
            this.dbContext.CustomInvoices.Load();
            this.customInvoiceBindingSource.DataSource = dbContext.CustomInvoices.Local.ToBindingList();
        }

        private void btnDirectToLeaseContract_Click(object sender, EventArgs e)
        {
            DirectToForm(new LeaseContractForm());
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

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var invoice = (CustomInvoice)this.dgvInvoices.CurrentRow?.DataBoundItem;

            if (invoice == null)
                return;

            this.dbContext.Entry(invoice)
            .Reference(i => i.Company)
            .Load();
        }

        private void btnPaidInvoice_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            //(dgvInvoices.CurrentCell.RowIndex + 1)
            var invoice = dbContext.CustomInvoices.Where(u => u.CustomInvoiceId == (dgvInvoices.CurrentCell.RowIndex + 1)).FirstOrDefault();
            
            if (invoice != null)
            {
                invoice.PaidAt = thisDay;
                dbContext.SaveChanges();
                dgvInvoices.Refresh();
            }

            

            
        }
    }
}
