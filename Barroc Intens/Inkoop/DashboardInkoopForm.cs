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

namespace Barroc_Intens
{
    public partial class DashboardInkoopForm : Form
    {
        private AppDbContext dbContext;

        public DashboardInkoopForm()
        {
            InitializeComponent();
        }

        private void DashboardInkoopForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Products.Load();

            this.dbContext.Categories.Load();

            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();

        }

        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;

            if (product == null)
                return;

            this.dbContext.Entry(product)
            .Reference(p => p.Category)
            .Load();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inkoop.AddProductFrom addProductFrom = new Inkoop.AddProductFrom();
            addProductFrom.ShowDialog();
            this.Close();
        }

        private void categoriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var category = (Category)this.categoriesDataGridView.CurrentRow?.DataBoundItem;

            if (category == null)
                return;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inkoop.AddCategoryForm addCategoryForm = new Inkoop.AddCategoryForm();
            addCategoryForm.ShowDialog();
            this.Close();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Barroc_Intens.MainForm mainForm = new Barroc_Intens.MainForm();
            mainForm.ShowDialog();
            this.Close();
        }


    }
}
