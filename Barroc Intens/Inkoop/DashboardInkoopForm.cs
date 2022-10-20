﻿using Barroc_Intens.Classes;
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
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.RolId);
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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;

            dbContext.Products.Update(product);
            dbContext.SaveChanges();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;

            productsDataGridView.Rows.RemoveAt(productsDataGridView.SelectedRows[0].Index);

            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
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

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var category = (Category)this.categoriesDataGridView.CurrentRow?.DataBoundItem;

            dbContext.Categories.Update(category);
            dbContext.SaveChanges();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            var category = (Category)this.categoriesDataGridView.CurrentRow?.DataBoundItem;

            categoriesDataGridView.Rows.RemoveAt(categoriesDataGridView.SelectedRows[0].Index);

            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Barroc_Intens.MainForm mainForm = new Barroc_Intens.MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnInkoop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inkoop.ProductenForm productenForm = new Inkoop.ProductenForm();
            productenForm.ShowDialog();
            this.Close();
        }
    }
}
