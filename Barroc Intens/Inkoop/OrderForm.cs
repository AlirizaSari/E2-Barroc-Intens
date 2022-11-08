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
    public partial class OrderForm : Form
    {
        private AppDbContext dbContext;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            this.dbContext = new AppDbContext();
            this.dbContext.Products.Where(ss => ss.StockStatus == "Besteld")
                .Include(c => c.Category)
                .Load();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnBackToDashbaord_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }

        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            var product = (Product)this.dgvProductsOrders.CurrentRow?.DataBoundItem;

            product.AmountInStock += product.OrderAmount;
            product.OrderAmount = 0;
            product.StockStatus = "Momenteel leverbaar";

            dbContext.Products.Update(product);
            dbContext.SaveChanges();
            dgvProductsOrders.Refresh();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            var product = (Product)this.dgvProductsOrders.CurrentRow?.DataBoundItem;

            if (product.AmountInStock > 0)
            {
                product.OrderAmount = 0;
                product.StockStatus = "Momenteel leverbaar";
                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }
            else
            {
                product.OrderAmount = 0;
                product.StockStatus = "Uit voorraad";
                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }

            dgvProductsOrders.Refresh();
        }
    }
}
