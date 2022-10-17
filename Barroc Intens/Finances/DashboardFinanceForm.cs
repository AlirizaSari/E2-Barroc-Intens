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
        }

        private void btnDirectToInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
            this.Close();
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
