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
            this.Hide();
            DashboardSalesForm dashboardSalesForm = new DashboardSalesForm();
            dashboardSalesForm.ShowDialog();
            this.Close();
        }


        private void pboxLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void CustomerNotesForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Database.EnsureCreated();    
            this.dbContext.Companies.Load();
            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
        }

        private void btnSaveToDb_Click(object sender, EventArgs e)
        {
            //var noteToAdd = new Note
            //{
            //    NoteId = 1,
            //    NoteDesription = txbConversationReport.ToString(),
            //    CompanyId = companyIdDataGridViewTextBoxColumn.Index,
                
            //};
            //this.dbContext.Notes.Add(noteToAdd);
        }
    }
}
