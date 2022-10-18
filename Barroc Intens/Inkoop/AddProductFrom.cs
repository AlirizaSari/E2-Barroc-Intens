using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens.Inkoop
{
    public partial class AddProductFrom : Form
    {
        private AppDbContext dbContext;

        public AddProductFrom()
        {
            InitializeComponent();
        }

        private void AddProductFrom_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = txbNameProduct.Text,
                Description = txbDescriptionProduct.Text,
                Price = decimal.Parse(txbPriceProduct.Text),
                Category = dbContext.Categories.FirstOrDefault(c => c.Name == txbCategoryProduct.Text)
            };
            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            this.Hide();
            DashboardInkoopForm dashboardInkoopForm = new DashboardInkoopForm();
            dashboardInkoopForm.ShowDialog();
            this.Close();
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardInkoopForm dashboardInkoopForm = new DashboardInkoopForm();
            dashboardInkoopForm.ShowDialog();
            this.Close();
        }

    }
}
