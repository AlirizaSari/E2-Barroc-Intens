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
    public partial class AddCategoryForm : Form
    {
        private AppDbContext dbContext;

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                Name = txbNameCategory.Text,
                IsEmployeeOnly = int.Parse(txbIsEmployeeOnlyCategory.Text)

            };
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();

            DirectToForm(new DashboardInkoopForm());
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
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
