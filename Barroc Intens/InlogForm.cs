using Barroc_Intens.Classes;
using Microsoft.EntityFrameworkCore;
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
        private Form currentForm = Form.ActiveForm;
        

        public InlogForm()
        {
            InitializeComponent();
    }

        private void InlogForm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            this.dbContext = new AppDbContext();
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
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
                UserLoginInformation.LoginUserName = rec.UserName;
                UserLoginInformation.LoginName = rec.Name;
                UserLoginInformation.LoginUserId = rec.UserId;
                UserLoginInformation.LoginRolId = rec.RolId;

                //admin
                if (rec.RolId == 1)
                {
                    DirectToForm(new MainForm());
                }
                //finances
                else if (rec.RolId == 2 || rec.RolId == 3)
                {
                    DirectToForm(new DashboardFinanceForm());
                }
                //Sales
                else if (rec.RolId == 4 || rec.RolId == 5)
                {
                    DirectToForm(new DashboardSalesForm());
                }
                //Inkoop
                else if (rec.RolId == 6 || rec.RolId == 7)
                {
                    DirectToForm(new DashboardInkoopForm());
                }
                //Maintenance
                else if (rec.RolId == 8 || rec.RolId == 9)
                {
                    DirectToForm(new DashboardMaintenanceForm());
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

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

    }
}
