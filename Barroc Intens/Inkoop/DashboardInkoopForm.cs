using Barroc_Intens.Classes;
using Barroc_Intens.Inkoop;
using Barroc_Intens.Inkoop.Categories;
using Barroc_Intens.Inkoop.Products;
using Barroc_Intens.Sales;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Barroc_Intens
{
    public partial class DashboardInkoopForm : Form
    {
        private AppDbContext dbContext;

        public DashboardInkoopForm()
        {
            InitializeComponent();
            lblAccountName.Text = UserLoginInformation.LoginUserName;
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.LoginRolId);

            if (UserLoginInformation.LoginRolId != 1)
            {
                btnBackToMain.Visible = false;
                btnInkoop.Location = new Point(52, 117);
                btnInkoop.Location = new Point(272, 117);
            }

            if (UserLoginInformation.LoginRolId != 1 && UserLoginInformation.LoginRolId != 6)
            {
                btnAddProduct.Visible = false;
                btnEditProduct.Visible = false;
                btnRemoveProduct.Visible = false;
                btnAddCategory.Visible = false;
                btnEditCategory.Visible = false;
                btnRemoveCategory.Visible = false;
                btnOrders.Visible = false;
            }
        }

        private void DashboardInkoopForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Products.Load();

            this.dbContext.Categories.Load();

            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();

        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var product = (Product)this.dgvProducts.CurrentRow?.DataBoundItem;

            if (product == null)
                return;

            this.dbContext.Entry(product)
            .Reference(p => p.Category)
            .Load();

        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DirectToForm(new AddProductForm());
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var currSelect = (Product)dgvProducts.CurrentRow?.DataBoundItem;
            DirectToForm(new EditProductForm(currSelect));

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var product = (Product)this.dgvProducts.CurrentRow?.DataBoundItem;

            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
            dgvProducts.Refresh();
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var category = (Category)this.dgvCategories.CurrentRow?.DataBoundItem;

            if (category == null)
                return;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DirectToForm(new AddCategoryForm());
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var currSelect = (Category)dgvCategories.CurrentRow?.DataBoundItem;
            DirectToForm(new EditCategoryForm(currSelect));
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            var category = (Category)this.dgvCategories.CurrentRow?.DataBoundItem;

            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
            dgvCategories.Refresh();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardAdminForm());
        }

        private void btnInkoop_Click(object sender, EventArgs e)
        {
            DirectToForm(new ProductenForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DirectToForm(new InlogForm());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            DirectToForm(new OrderForm());
        }
    }
}
