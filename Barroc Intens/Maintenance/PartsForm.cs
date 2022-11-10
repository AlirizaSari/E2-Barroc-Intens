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

namespace Barroc_Intens.Maintenance
{
    public partial class PartsForm : Form
    {
        private AppDbContext dbContext;

        public PartsForm()
        {
            InitializeComponent();
        }

        private void PartsForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Categories.Load();

            this.dbContext.StockStatuses.Load();

            //this.dbContext.Products.Load();

            this.dbContext.Products.Where(p => p.CategoryId == 3)
                .Load();

            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            UpdateLabels();

        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardMaintenanceForm());
        }


        private void UpdateLabels()
        {
            if (this.dbContext == null)
                return;

            var product = (Product)this.dgvParts.CurrentRow?.DataBoundItem;

            if (product == null)
                return;

            lblProductName.Text = product?.Name;
            //lblProductDescription.Text = product?.Description;
            lblProductBrand.Text = product?.Brand;

            if (product.StockStatus != null)
                lblProductStockStatus.Text = product.StockStatus.Name;

            if (product.Category != null)
                lblProductCategory.Text = product.Category.Name;
        }

        private void dgvParts_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}
