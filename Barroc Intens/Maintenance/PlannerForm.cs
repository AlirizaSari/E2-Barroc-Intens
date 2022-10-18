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
            this.mcaMalfunctionCalendar.BoldedDates = new System.DateTime[] { today };
        }
    }
}
