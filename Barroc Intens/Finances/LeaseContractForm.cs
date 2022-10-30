using Barroc_Intens.Classes;
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

namespace Barroc_Intens.Finances
{
    public partial class LeaseContractForm : Form
    {
        private AppDbContext dbContext;

        public LeaseContractForm()
        {
            InitializeComponent();

        }

        

        private void LeaseContractForm_Load(object sender, EventArgs e)
        {
        this.dbContext = new AppDbContext();

        this.dbContext.Companies.Load();
        this.dbContext.LeaseContracts.Load();

        this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
        }

        private void dgvCompanys_SelectionChanged(object sender, EventArgs e)
        {
            
            if (this.dbContext == null)
                return;

            var companies = (Company)this.dgvCompanys.CurrentRow?.DataBoundItem;

            if (companies == null)
                return;
            else
            {
                if (companies.BkrCheckedAt != null)
                {
                    chbBkrCheckPositive.Checked = true;
                    chbBkrCheckNegative.CheckState = CheckState.Unchecked;
                }
                else
                {
                    chbBkrCheckNegative.Checked = true;
                    chbBkrCheckPositive.CheckState = CheckState.Unchecked;
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        //public string NoteDesription { get; set; }

        //public DateTime date { get; set; }

        //public int CompanyId { get; set; }
        //public Company Company { get; set; } = null;

        //public int UserId { get; set; }
        //public User User { get; set; } = null;
        //var leaseContract = new LeaseContract
        //    {
        //        BkrRegisterChecked = ,
        //        companyId = ,

                

        //    };
        //    dbContext.Categories.Add(category);
        //    dbContext.SaveChanges();

        }

        private void btnDirectToFinanceDash_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
