using Barroc_Intens.Classes;
using Barroc_Intens.Finances.LeaseContracts;
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

            var companies = (Company)this.dgvCompanies.CurrentRow?.DataBoundItem;

            if (companies == null)
                return;
            else
            
            // you may now make a selection of a company in the datagridview. depending on the data it finds about a bkrRegistration it wil check a box if this data is registerd or not. s.smit
            
            {
                if (companies.BkrCheckedAt != null)
                {
                    cbBkrPositive.Checked = true;
                    cbBkrNegative.Checked = false;
                    //cbBkrNegative.CheckState = CheckState.Unchecked;
                }
                else
                {
                    cbBkrNegative.Checked = true;
                    cbBkrPositive.Checked = false;
                    //cbBkrPositive.CheckState = CheckState.Unchecked;
                }
                
            }

            this.dbContext.Entry(companies)
            .Reference(c => c.User)
            .Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var companies = (Company)this.dgvCompanies.CurrentRow?.DataBoundItem;
            int bkrResult;
            if (cbBkrNegative.Checked != true)
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

        private void cbBkrPositive_Click(object sender, EventArgs e)
        {
            cbBkrNegative.Checked = false;
        }

        private void cbBkrNegative_Click(object sender, EventArgs e)
        {
            cbBkrPositive.Checked = false;
        }

        private void btnCreateLeaseContract_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string company = dgvCompanies.CurrentRow.Cells[0].Value.ToString();
            var companyInformation = (Company)dgvCompanies.CurrentRow.DataBoundItem;

            if (cbBkrPositive.Checked)
            {
                CreateLeaseContractForm createLeaseContractForm = new CreateLeaseContractForm(companyInformation);
                createLeaseContractForm.ShowDialog();
            }
            else
            {
                lblError.Text = $"Negatieve BKR van {companyInformation.Name}";
            }
            
        }
    }
}
