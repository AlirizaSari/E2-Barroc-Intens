using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens.Maintenance
{
    public partial class PlannerForm : Form
    {

        public PlannerForm()
        {
            InitializeComponent();

            
        }

        private void PlannerForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            DateTime[] dates = { today.AddDays(1),
            today.AddDays(3), today.AddDays(5)};

            mcaMalfunctionCalendar.BoldedDates = dates;

            //for (int r = 0; r < dates.GetLength(0); r++)
            //{
            //    DataGridViewRow gridView = new DataGridViewRow();
            //    gridView.CreateCells(dgvMaintenanceInformation);

            //    for (int c = 0; c < dates.GetLength(1); c++)
            //    {
            //        gridView.CreateCells[c].Value = dates;
            //    }
            //}
        }
    }
}
