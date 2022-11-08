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
    }
}
