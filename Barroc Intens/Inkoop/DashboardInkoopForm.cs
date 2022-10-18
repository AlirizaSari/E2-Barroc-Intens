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
    public partial class DashboardInkoopForm : Form
    {
        public DashboardInkoopForm()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Barroc_Intens.MainForm mainForm = new Barroc_Intens.MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
