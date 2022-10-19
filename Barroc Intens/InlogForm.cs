﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens
{
    public partial class InlogForm : Form
    {
        private AppDbContext dbContext;

        public InlogForm()
        {
            InitializeComponent();
        }

        private void InlogForm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            this.dbContext = new AppDbContext();
            this.dbContext.Users.Load();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            var rec = dbContext.Users.Where(a => a.UserName == username && a.Password == password).FirstOrDefault();

            
            //has succesfully logged in
            if (rec != null)
            {
                //admin
                if (rec.RolId == 1)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                //finances
                else if (rec.RolId == 2 || rec.RolId == 3)
                {
                    this.Hide();
                    DashboardFinanceForm dashboardFinanceForm = new DashboardFinanceForm();
                    dashboardFinanceForm.ShowDialog();
                    this.Close();
                }
                //Sales
                else if (rec.RolId == 4 || rec.RolId == 5)
                {
                    this.Hide();
                    DashboardSalesForm dashboardSalesForm = new DashboardSalesForm();
                    dashboardSalesForm.ShowDialog();
                    this.Close();
                }
                //Inkoop
                else if (rec.RolId == 6 || rec.RolId == 7)
                {
                    this.Hide();
                    DashboardInkoopForm dashboardInkoopForm = new DashboardInkoopForm();
                    dashboardInkoopForm.ShowDialog();
                    this.Close();
                }
                //Maintenance
                else if (rec.RolId == 8 || rec.RolId == 9)
                {
                    this.Hide();
                    DashboardMaintenanceForm dashboardMaintenanceForm = new DashboardMaintenanceForm();
                    dashboardMaintenanceForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                lblError.Text = "Inloggegevens zijn onjuist";
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            DisableLoginButton();
        }

        private void InlogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            DisableLoginButton();
        }

        private void DisableLoginButton()
        {
            if ((txbPassword.Text).Count() < 1 || (txbPassword.Text).Count() < 1)
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

    }
}
