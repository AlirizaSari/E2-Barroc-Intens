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
        string _txtTitleHeader = "";
        string _ConvertationText = "";
        string _date;
        
        public CustomerNotesForm()
        {
            InitializeComponent();
        }

        private void btnExportText_Click(object sender, EventArgs e)
        {
           

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Barroc_Intens.MainForm mainForm = new Barroc_Intens.MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
