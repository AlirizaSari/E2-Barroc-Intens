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

namespace Barroc_Intens.Sales
{
    public partial class CustomerNotesForm : Form
    {
        private AppDbContext dbContext;
        public CustomerNotesForm()
        {
            InitializeComponent();
        }


        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardSalesForm());
        }


        private void pboxLogo_Click(object sender, EventArgs e)
        {
            DirectToForm(new MainForm());
        }

        private void CustomerNotesForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();   

            this.dbContext = new AppDbContext();
            this.dbContext.Companies.Load();
            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
        }

       
        private void companyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void companyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveToDb_Click_1(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var selectedCompany = (Company)this.companyDataGridView.CurrentRow?.DataBoundItem;

            if (selectedCompany == null)
                return;

            var noteToAdd = new Note
            {
                NoteDesription = txbConversationReport.Text,
                date = DateTime.Now,
                CompanyId = selectedCompany.CompanyId,
                UserId = 1,
            };

            this.dbContext.Notes.Add(noteToAdd);
            this.dbContext.SaveChanges();
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
