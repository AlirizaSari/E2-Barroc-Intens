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
    public partial class InvoiceOverviewForm : Form
    {
        private AppDbContext dbContext;
        public InvoiceOverviewForm()
        {
            InitializeComponent();
        }

        private void btnBackToFinanceDashboard_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void InvoiceOverviewForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.CustomInvoices.Where(ccc => ccc.PaidAt != null)
                .Include(ci => ci.Company)
                .Include(ci => ci.Product)
                .Load();
            this.dgvPaidInvoices.DataSource = dbContext.CustomInvoices.Local
                .ToBindingList();

            this.dbContext = new AppDbContext();
            this.dbContext.CustomInvoices.Where(np => np.PaidAt == null)
                .Include(cu => cu.Company)
                .Include(ci => ci.Product)
                .Load();
            this.dgvNotPaidInvoices.DataSource = dbContext.CustomInvoices.Local.ToBindingList();

        }
        
        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void dgvPaidInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currSelect = (CustomInvoice)dgvPaidInvoices.CurrentRow?.DataBoundItem;

            InvoiceInformationForm invoiceInformationForm = new InvoiceInformationForm(currSelect);
            invoiceInformationForm.ShowDialog();
        }

        private void dgvNotPaidInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currSelect = (CustomInvoice)dgvNotPaidInvoices.CurrentRow?.DataBoundItem;

            InvoiceInformationForm invoiceInformationForm = new InvoiceInformationForm(currSelect);
            invoiceInformationForm.ShowDialog();
        }
    }
}
