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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDirectToFinances_Click(object sender, EventArgs e)
        {
            Finances.InvoiceForm invoiceForm = new Finances.InvoiceForm();
            invoiceForm.ShowDialog();
        }

        private void btnDirectToSales_Click(object sender, EventArgs e)
        {
            Sales.CustomerNotesForm CustomerNotesForm = new Sales.CustomerNotesForm();
            CustomerNotesForm.ShowDialog();
        }
    }
}
