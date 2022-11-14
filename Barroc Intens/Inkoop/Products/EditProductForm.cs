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

namespace Barroc_Intens.Inkoop.Products
{
    public partial class EditProductForm : Form
    {
        private AppDbContext dbContext;
        Product _product;

        public EditProductForm(Product myProduct)
        {
            InitializeComponent();

            _product = myProduct;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Categories.Load();
            this.dbContext.Products.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
            this.productsBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            txbNameProduct.Text = _product.Name;
            txbDescriptionProduct.Text = _product.Description;
            txbBrandProduct.Text = _product.Brand;

            cboxProductCategory.SelectedIndex = cboxProductCategory.FindStringExact(_product.Category.Name);
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var currSelect = (Category)cboxProductCategory.SelectedItem;
            var saveProduct = dbContext.Products.Where(p => p.ProductId == _product.ProductId).FirstOrDefault();

            saveProduct.Name = txbNameProduct.Text;
            saveProduct.Description = txbDescriptionProduct.Text;
            saveProduct.Brand = txbBrandProduct.Text;
            saveProduct.CategoryId = (int)cboxProductCategory.SelectedValue;

            dbContext.Products.Update(saveProduct);
            dbContext.SaveChanges();
            DirectToForm(new DashboardInkoopForm());
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }
    }
}
