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

        public CreateLeaseContractForm(Company myCompany)
        {
            InitializeComponent();
            txbCity.Text = myCompany.City;
            txbHouseNumber.Text = myCompany.HouseNumber;
            txbStreet.Text = myCompany.Street;
            txbTelephoneNumber.Text = myCompany.Phone;
            _company = myCompany;
            //
        }

        private void CreateInvoiceForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Companies.Load();
            this.dbContext.Products.Load();
            this.companyBindingSource.DataSource = dbContext.Companies.Local.Where(comp => comp.Name == _company.Name);
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
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

            if (!string.IsNullOrEmpty(_paymentTerm))
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
            }
            

            
            
        }
    }
}
