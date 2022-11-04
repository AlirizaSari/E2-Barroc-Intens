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
            this.dbContext.CustomInvoices.Where(p => p.PaidAt != null)
                .Include(ci => ci.Company)
                .Load();
            this.dgvPaidInvoices.DataSource = dbContext.CustomInvoices.Local
                .ToBindingList();

            this.dbContext.CustomInvoices.Where(p => p.PaidAt == null)
                .Include(ci => ci.Company)
                .Load();
            this.dgvNotPaidInvoices.DataSource = dbContext.CustomInvoices.Local.ToBindingList();

            //this.dbContext.CustomInvoices.Include(ci => ci.Company);
            //.Reference(i => i.Company)
            //.Load();
        }
        
        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
