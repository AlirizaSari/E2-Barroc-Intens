﻿using Microsoft.EntityFrameworkCore;
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

            this.dbContext.Categories.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {

            var product = new Product
            {
                Name = txbNameProduct.Text,
                Description = txbDescriptionProduct.Text,
                Brand = txbBrandProduct.Text,
                CategoryId = (int)newProductCategoryComboBox.SelectedValue
            };
            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            DirectToForm(new DashboardInkoopForm());
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

    }
}
