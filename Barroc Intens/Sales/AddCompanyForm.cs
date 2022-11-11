using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens.Sales
{
    public partial class AddCompanyForm : Form
    {
        private AppDbContext dbContext;

        public AddCompanyForm()
        {
            InitializeComponent();
        }

        private void AddCompanyForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            var company = new Company
            {
                Name = txbCompanyName.Text,
                Phone = txbCompanyPhone.Text,
                EmailAddress = txbCompanyEmail.Text,
                Street = txbCompanyStreet.Text,
                HouseNumber = txbCompanyHouseNumber.Text,
                City = txbCompanyCity.Text,
                CountryCode = txbCompanyCountryCode.Text,
                IsBkrChecked = false,
                BkrCheckedAt = null
            };
            dbContext.Companies.Add(company);
            dbContext.SaveChanges();

            DirectToForm(new DashboardSalesForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnCancelCompany_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardSalesForm());
        }

    }
}
