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
        Leasecontract _leaseCcontract;
        string _paymentTerm;

        public EditLeaseContractForm(Leasecontract myLeaseContract)
        {
            InitializeComponent();
            
            _leaseCcontract = myLeaseContract;
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
            this.dbContext.Companies.Load();
            this.dbContext.Products.Load();
            //this.companyBindingSource.DataSource = dbContext.Companies.Local.Where(comp => comp.Name == _company.Name);
            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            cboxCompany.SelectedIndex = cboxCompany.FindStringExact(_leaseCcontract.Company.ToString());
            cboxProducts.SelectedIndex = cboxProducts.FindStringExact(_leaseCcontract.Product.Name);

        }

        private void EditLeaseContractForm_Click(object sender, EventArgs e)
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
                DirectToForm(new LeaseContractForm());
            }
            else
            {
                lblError.Text = "Vink de betaaltermijn aan";
            }
            
        }

       

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnEditLeaseContract_Click(object sender, EventArgs e)
        {

        }
    }
}
