using Barroc_Intens.Classes;
using Barroc_Intens.Finances;
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
        public DashboardFinanceForm()
        {
            InitializeComponent();
            lblAccountName.Text = UserLoginInformation.LoginUserName;
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.LoginRolId);
            
            if (UserLoginInformation.LoginRolId != 1)
            {
                pboxLogo.Visible = false;
                btnBackToMain.Visible = false;
            }
        }

        private void btnDirectToInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// If you click on the logo, you will be redirected to the homepage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxLogo_Click(object sender, EventArgs e)
        {
            DirectToForm(new MainForm());
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            DirectToForm(new MainForm());
        }

        private void DashboardFinanceForm_Load(object sender, EventArgs e)
        {
            txbExtraInfo.Text = "Dit is een test";
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
    }
}
