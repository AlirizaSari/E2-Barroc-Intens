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

namespace Barroc_Intens.Inkoop
{
    public partial class ProductenForm : Form
    {
        private AppDbContext dbContext;

        public ProductenForm()
        {
            InitializeComponent();
        }

        private void ProductenForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Categories.Load();

            //this.dbContext.Products.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();

            ShowProducts();

        }

        private void btnBackToInkoopDashboard_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void ShowProducts()
        {

            if (this.dbContext == null)
                return;

            var category = (Category)cboxCategory.SelectedItem;

            if (category == null)
                return;

            this.dbContext.Entry(category)
                .Collection(c => c.Products)
                .Load();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var product = (Product)this.dgvProducts.CurrentRow?.DataBoundItem;

            if (product == null)
                return;

            lblProductName.Text = product?.Name;
            //lblProductDescription.Text = product?.Description;
            lblProductBrand.Text = product?.Brand;
            lblProductAmountInStock.Text = product?.AmountInStock.ToString();

            if (product.Category != null)
                lblProductCategory.Text = product.Category.Name;

        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            var product = (Product)this.dgvProducts.CurrentRow?.DataBoundItem;
;
            product.AmountInStock += (int?)nupAmountProduct.Value;

            this.dbContext.SaveChanges();
            this.dgvProducts.Refresh();
        }

    }
}
