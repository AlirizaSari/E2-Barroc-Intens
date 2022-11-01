﻿using Barroc_Intens.Classes;
using Barroc_Intens.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens
{
    public partial class DashboardSalesForm : Form
    {
        private AppDbContext dbContext;

        public DashboardSalesForm()
        {
            InitializeComponent();
            lblAccountName.Text = UserLoginInformation.LoginUserName;
            lblDepartment.Text = UserLoginInformation.ConvertRoleId(UserLoginInformation.LoginRolId);

            if (UserLoginInformation.LoginRolId != 1)
            {
                btnBackToMain.Visible = false;
                btnCustomerNotes.Location = new Point(52,117);
                btnLocation3.Location = new Point(280, 117);
            }
        }

        private void DashboardSalesForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardAdminForm());
        }

        private void btnCustomerNotes_Click(object sender, EventArgs e)
        {
            DirectToForm(new CustomerNotesForm()); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DirectToForm(new InlogForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
