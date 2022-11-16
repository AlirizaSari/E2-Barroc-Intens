using Barroc_Intens.Classes;
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

namespace Barroc_Intens.Finances.LeaseContracts
{
    public partial class EditLeaseContractForm : Form
    {
        private AppDbContext dbContext;
        Leasecontract _leaseContract;
        string _paymentTerm;

        public EditLeaseContractForm(Leasecontract myLeaseContract)
        {
            InitializeComponent();
            
            _leaseContract = myLeaseContract;
            dtpCreateDate.Value = myLeaseContract.CreateDate;
            
            if (myLeaseContract.PaymentTerm == "Maandelijks")
            {
                cbMonthly.Checked = true;
                cbYearly.Checked = false;
            }
            else if (myLeaseContract.PaymentTerm == "Jaarlijks")
            {
                cbYearly.Checked = true;
                cbMonthly.Checked = false;
            }
        }

        private void EditLeaseContractForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Companies.OrderBy(c => c.Name).Load();
            this.dbContext.Products.Where(c => c.CategoryId == 1).Load();
            //this.dbContext.LeaseContracts.Where(l => l == _leaseContract).Load();
            //this.companyBindingSource.DataSource = dbContext.Companies.Local.Where(comp => comp.Name == _company.Name);
            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            

            cboxCompany.SelectedIndex = cboxCompany.FindStringExact(_leaseContract.Company.ToString());
            cboxProducts.SelectedIndex = cboxProducts.FindStringExact(_leaseContract.Product.Name);

        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnEditLeaseContract_Click(object sender, EventArgs e)
        {
            var currSelect = (Company)cboxCompany.SelectedItem;
            var saveLease = dbContext.LeaseContracts.Where(l => l == _leaseContract).FirstOrDefault();

            if (cbMonthly.Checked)
            {
                _paymentTerm = "Maandelijks";
            }
            else if (cbYearly.Checked)
            {
                _paymentTerm = "Jaarlijks";
            }

            if (!string.IsNullOrEmpty(_paymentTerm) && currSelect.IsBkrChecked)
            {

                saveLease.CreateDate = dtpCreateDate.Value;
                saveLease.PaymentTerm = _paymentTerm;
                saveLease.ProductId = (int)cboxProducts.SelectedValue;
                saveLease.CompanyId = (int)cboxCompany.SelectedValue;

                dbContext.SaveChanges();
                DirectToForm(new LeaseContractForm());
            }
            else if(!currSelect.IsBkrChecked)
            {
                lblError.Text = $"BKR van {currSelect.Name} is (nog) niet goedgekeurd";
            }
            else
            {
                lblError.Text = "Vink de betaaltermijn aan";
            }
        }

        private void cbMonthly_Click(object sender, EventArgs e)
        {
            cbYearly.Checked = false;
        }

        private void cbYearly_Click(object sender, EventArgs e)
        {
            cbMonthly.Checked = false;
        }

        private void btnBackToLease_Click(object sender, EventArgs e)
        {
            DirectToForm(new LeaseContractForm());
        }
    }
}
