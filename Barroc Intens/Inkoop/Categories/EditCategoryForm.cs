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

namespace Barroc_Intens.Inkoop.Categories
{
    public partial class EditCategoryForm : Form
    {
        private AppDbContext dbContext;
        Category _category;
        public EditCategoryForm(Category myCategory)
        {
            InitializeComponent();

            _category = myCategory;
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Categories.Load();

            txbNameCategory.Text = _category.Name;

            if (_category.IsEmployeeOnly)
            {
                cbEmployeeOnly.Checked = true;
            }
            else
            {
                cbEmployeeOnly.Checked = false;
            }
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var saveCategory = dbContext.Categories.Where(c => c.CategoryId == _category.CategoryId).FirstOrDefault();

            saveCategory.Name = txbNameCategory.Text;
            if (cbEmployeeOnly.Checked)
            {
                saveCategory.IsEmployeeOnly = true;
            }
            else
            {
                saveCategory.IsEmployeeOnly= false;
            }

            dbContext.Categories.Update(saveCategory);
            dbContext.SaveChanges();
            DirectToForm(new DashboardInkoopForm());
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardInkoopForm());
        }
    }
}
