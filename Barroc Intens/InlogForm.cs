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

            if (rec != null)
            {
                MessageBox.Show("Ingelogd");
                this.Hide();
                Barroc_Intens.MainForm mainForm = new Barroc_Intens.MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gegevens zijn fout");
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txbUsername.Text).Count() < 1)
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void InlogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
