using Barroc_Intens.Finances;
using BarrocItems.Finances;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnDirectToFinances_Click(object sender, EventArgs e)
        {
            Finances.InvoiceForm invoiceForm = new Finances.InvoiceForm();
            invoiceForm.ShowDialog();
        }
    }
}
