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
            
            // you may now make a selection of a company in the datagridview. depending on the data it finds about a bkrRegistration it wil check a box if this data is registerd or not. s.smit
            
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
            var companies = (Company)this.dgvCompanys.CurrentRow?.DataBoundItem;
            int bkrResult;
            if (chbBkrCheckNegative.Checked != true)
            {
                bkrResult = 1;
            }
            else
            {
                bkrResult = 0;
            }
            

            var leaseContract = new Leasecontract
            {
                CompanyId = companies.CompanyId,
                BkrChecked = bkrResult,
                UserId = companies.UserId,
            };

            dbContext.LeaseContracts.Add(leaseContract);
            dbContext.SaveChanges();

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
