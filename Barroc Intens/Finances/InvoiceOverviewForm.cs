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
                .Load();
            this.dgvPaidInvoices.DataSource = dbContext.CustomInvoices.Local
                .ToBindingList();

            this.dbContext = new AppDbContext();
            this.dbContext.CustomInvoices.Where(np => np.PaidAt == null)
                .Include(cu => cu.Company)
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
            string companyName = dgvPaidInvoices.CurrentRow.Cells[0].Value.ToString();
            string invoicePaidAt = dgvPaidInvoices.CurrentRow.Cells[2].Value.ToString();
            string companyEmail = dgvPaidInvoices.CurrentRow.Cells[3].Value.ToString();
            string companyAddress = dgvPaidInvoices.CurrentRow.Cells[4].Value.ToString();
            double hoursWorked = Convert.ToDouble(dgvPaidInvoices.CurrentRow.Cells[5].Value.ToString());
            double discount = Convert.ToDouble(dgvPaidInvoices.CurrentRow.Cells[6].Value.ToString());
            double pricePerHour = Convert.ToDouble(dgvPaidInvoices.CurrentRow.Cells[7].Value.ToString());
            string notes = dgvPaidInvoices.CurrentRow.Cells[8].Value.ToString();
            string paymentTerm = dgvPaidInvoices.CurrentRow.Cells[9].Value.ToString();


            InvoiceInformationForm invoiceInformationForm = new InvoiceInformationForm(companyName,
                invoicePaidAt,
                companyEmail,
                companyAddress,
                hoursWorked,
                discount,
                pricePerHour,
                notes,
                paymentTerm);
            invoiceInformationForm.ShowDialog();
        }

        private void dgvNotPaidInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string companyName = dgvNotPaidInvoices.CurrentRow.Cells[0].Value.ToString();
            string invoicePaidAt = "";
            string companyEmail = dgvNotPaidInvoices.CurrentRow.Cells[3].Value.ToString();
            string companyAddress = dgvNotPaidInvoices.CurrentRow.Cells[4].Value.ToString();
            double hoursWorked = Convert.ToDouble(dgvNotPaidInvoices.CurrentRow.Cells[5].Value.ToString());
            double discount = Convert.ToDouble(dgvNotPaidInvoices.CurrentRow.Cells[6].Value.ToString());
            double pricePerHour = Convert.ToDouble(dgvNotPaidInvoices.CurrentRow.Cells[7].Value.ToString());
            string notes = dgvNotPaidInvoices.CurrentRow.Cells[8].Value.ToString();
            string paymentTerm = dgvNotPaidInvoices.CurrentRow.Cells[9].Value.ToString();


            InvoiceInformationForm invoiceInformationForm = new InvoiceInformationForm(companyName,
                invoicePaidAt,
                companyEmail,
                companyAddress,
                hoursWorked,
                discount,
                pricePerHour,
                notes,
                paymentTerm);
            invoiceInformationForm.ShowDialog();
        }
    }
}
