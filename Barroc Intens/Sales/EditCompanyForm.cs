using Barroc_Intens.Classes;
using Barroc_Intens.Finances;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens.Sales
{
    public partial class EditCompanyForm : Form
    {
        private AppDbContext dbContext;
        Company _company;

        public EditCompanyForm(Company myCompany)
        {
            InitializeComponent();

            _company = myCompany;

            
        }

        private void EditCompanyForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Companies.Load();

            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();

            txbCompanyName.Text = _company.Name;
            txbCompanyPhone.Text = _company.Phone;
            txbCompanyEmail.Text = _company.EmailAddress;
            txbCompanyStreet.Text = _company.Street;
            txbCompanyHouseNumber.Text = _company.HouseNumber;
            txbCompanyCity.Text = _company.City;
            txbCompanyCountryCode.Text = _company.CountryCode;

            if (_company.IsBkrChecked)
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

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            var saveCompany = dbContext.Companies.Where(c => c.CompanyId == _company.CompanyId).FirstOrDefault();

            saveCompany.Name = txbCompanyName.Text;
            saveCompany.Phone= txbCompanyPhone.Text;
            saveCompany.EmailAddress = txbCompanyEmail.Text;
            saveCompany.Street = txbCompanyStreet.Text;
            saveCompany.HouseNumber = txbCompanyHouseNumber.Text;
            saveCompany.City = txbCompanyCity.Text;
            saveCompany.CountryCode = txbCompanyCountryCode.Text;

            if (cbBkr.Checked)
            {
                saveCompany.IsBkrChecked = true;
                saveCompany.BkrCheckedAt = DateTime.Now;
            }
            else
            {
                saveCompany.IsBkrChecked = false;
                saveCompany.BkrCheckedAt = null;

            }

            dbContext.Companies.Update(saveCompany);
            dbContext.SaveChanges();
            DirectToForm(new DashboardSalesForm());

        }

        private void btnCancelCompany_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardSalesForm());
        }
    }
}
