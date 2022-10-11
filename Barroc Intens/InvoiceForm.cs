using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocItems.Finances
{
    public partial class InvoiceForm : Form
    {
        string _companyName = "";
        string _companyAdress = "";
        string _comment = "";




        public InvoiceForm()
        {
            InitializeComponent();

            
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            _companyName = inputValidationString(txbCompanyName.Text);
            _companyAdress = txbCompanyAdress.Text;
            _comment = txbComments.Text;
        }

        private string inputValidationString(string myInput)
        {
            if (myInput == "")
            {
                lblError.Text = "Vul alstublieft elk vak in";
            }
            return myInput;
        }
    }
}
