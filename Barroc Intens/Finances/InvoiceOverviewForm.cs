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
    public partial class InvoiceOverviewForm : Form
    {
        public InvoiceOverviewForm()
        {
            InitializeComponent();
        }

        private void btnBackToFinanceDashboard_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
