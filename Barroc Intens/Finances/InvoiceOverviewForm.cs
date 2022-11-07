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
            string companyName = dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DateTime invoicePaidAt = Convert.ToDateTime(dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[2].Value.ToString());
            string companyEmail = dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string companyAddress = dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[4].Value.ToString();
            double hoursWorked = Convert.ToDouble(dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[5].Value.ToString());
            double discount = Convert.ToDouble(dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[6].Value.ToString());
            double pricePerHour = Convert.ToDouble(dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[7].Value.ToString());
            string notes = dgvPaidInvoices.Rows[dgvPaidInvoices.CurrentCell.RowIndex].Cells[8].Value.ToString();

            InvoiceInformationForm invoiceInformationForm = new InvoiceInformationForm(companyName,
                invoicePaidAt,
                companyEmail,
                companyAddress,
                hoursWorked,
                discount,
                pricePerHour,
                notes);
            invoiceInformationForm.ShowDialog();
        }
    }
}
