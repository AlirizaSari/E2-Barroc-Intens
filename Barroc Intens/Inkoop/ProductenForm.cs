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

            this.dbContext.Products.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();

            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
        }

        private void btnBackToInkoopDashboard_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var category = (Category)categoryComboBox.SelectedItem;

            if (category == null)
                return;

            this.dbContext.Entry(category)
                .Collection(c => c.Products)
                .Load();
        }

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var product = (Product)this.productDataGridView.CurrentRow?.DataBoundItem;

            if (product == null)
                return;

            lblProductName.Text = product?.Name;
            lblProductDescription.Text = product?.Description;
            lblProductBrand.Text = product?.Brand;

            if (product.Category != null)
                lblProductCategory.Text = product.Category.Name;
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
