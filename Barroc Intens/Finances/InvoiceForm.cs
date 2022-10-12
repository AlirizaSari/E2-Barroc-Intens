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
    public partial class InvoiceForm : Form
    {
        string _companyName;
        string _companyAdress;
        string _comment;
        string _date;
        decimal _hoursWorked;
        decimal _discount;
        decimal _pricePerHour;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
          
            _comment = txbComment.Text;
            _date = dtpDate.Text.ToString();
            _hoursWorked = nudHoursWorked.Value;
            _discount = nudDiscount.Value;
            _pricePerHour = nudHourlyPrice.Value;

            if (stringInputValidation(txbCompanyName.Text) && stringInputValidation(txbCompanyAdress.Text) && stringInputValidation(_date))
            {
                //do stuff
            }
        }

        private bool stringInputValidation(string companyInformation)
        {
            if (companyInformation == null)
            {
                lblError.Text = "Zorg ervoor dat alle velden zijn ingevuld";
                return false;
            }
            return true;
        }

        private bool decimalInputValidation(float invoiceInformation)
        {
            if (invoiceInformation == 0)
            {
                return false;
            }
            return true;
        }
    }
}
