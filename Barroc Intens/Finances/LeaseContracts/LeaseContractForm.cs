using Barroc_Intens.Classes;
using Barroc_Intens.Finances.LeaseContracts;
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

namespace Barroc_Intens.Finances
{
    public partial class LeaseContractForm : Form
    {
        private AppDbContext dbContext;

        public LeaseContractForm()
        {
            InitializeComponent();

        }

        

        private void LeaseContractForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Companies.Load();
            this.dbContext.LeaseContracts.Load();
            this.dbContext.Products.Load();

            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
            this.leasecontractBindingSource.DataSource = dbContext.LeaseContracts.Local.ToBindingList();
            
        }

        

        private void btnDirectToFinanceDash_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        
        private void btnCreateLeaseContract_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            
            CreateLeaseContractForm createLeaseContractForm = new CreateLeaseContractForm();
            createLeaseContractForm.ShowDialog();
        }

        private void dgvLeaseContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
