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
    public partial class CreateLeaseContractForm : Form
    {
        private AppDbContext dbContext;
        Company _company;
        string _paymentTerm;

        public CreateLeaseContractForm(/*Company myCompany*/)
        {
            InitializeComponent();
        }

        private void CreateInvoiceForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Companies.OrderBy(c => c.Name).Load();
            this.dbContext.Products.Where(p => p.CategoryId == 1).Load();
            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            var firstCompany = (Company)cboxCompany.SelectedItem;

            txbCity.Text = firstCompany.City;
            txbHouseNumber.Text = firstCompany.HouseNumber;
            txbStreet.Text = firstCompany.Street;
            txbTelephoneNumber.Text = firstCompany.Phone;
            _company = firstCompany;
            if (firstCompany.IsBkrChecked)
            {
                cbBkr.Checked = true;
            }
            else
            {
                cbBkr.Checked = false;
            }


        }

        private void btnCreateLeaseContract_Click(object sender, EventArgs e)
        {
            if (cbMonthly.Checked)
            {
                _paymentTerm = "Maandelijks";
            }
            else if (cbYearly.Checked)
            {
                _paymentTerm = "Jaarlijks";
            }

            int thisProduct = cboxProducts.SelectedIndex;

            if (!string.IsNullOrEmpty(_paymentTerm) && cbBkr.Checked)
            {
                var leaseContract = new Leasecontract()
                {
                    CreateDate = dtpCreateDate.Value,
                    PaymentTerm = _paymentTerm,
                    ProductId = (int)cboxProducts.SelectedValue,
                    CompanyId = (int)cboxCompany.SelectedValue
                };

                dbContext.LeaseContracts.Add(leaseContract);
                dbContext.SaveChanges();
                DirectToForm(new LeaseContractForm());
            }
            else if (!cbBkr.Checked)
            {
                lblError.Text = "BKR is (nog) niet gekeurd";
            }
            else
            {
                lblError.Text = "Vink de betaaltermijn aan";
            }
            
        }

        private void cboxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currSelect = (Company)cboxCompany.SelectedItem;
            txbCity.Text = currSelect.City;
            txbHouseNumber.Text = currSelect.HouseNumber;
            txbStreet.Text = currSelect.Street;
            txbTelephoneNumber.Text = currSelect.Phone;
            _company = currSelect;
            if (currSelect.IsBkrChecked)
            {
                cbBkr.Checked = true;
            }
            else
            {
                cbBkr.Checked = false;
            }
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            cbYearly.Checked = false;
        }

        private void cbYearly_CheckedChanged(object sender, EventArgs e)
        {
            cbMonthly.Checked = false;
        }

        private void btnBackToLease_Click(object sender, EventArgs e)
        {
            DirectToForm(new LeaseContractForm());
        }
    }
}
