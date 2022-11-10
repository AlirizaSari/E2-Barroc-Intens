using Barroc_Intens.Classes;
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
    public partial class InvoiceInformationForm : Form
    {
        string _companyName;
        string _notes;
        string _paymentTerm;
        double _hoursWorked;
        double _discount;
        double _pricePerHour;
        string _invoicePaidAt;
        CustomInvoice _customInvoice;

        public InvoiceInformationForm(CustomInvoice chosenInvoice)
        {
            InitializeComponent();
            _customInvoice = chosenInvoice;
        }

        private void InvoiceInformationForm_Load(object sender, EventArgs e)
        {

            txbCompany.Text = _customInvoice.Company.Name;
            txbCompanyEmail.Text = _customInvoice.Company.EmailAddress;
            txbCompanyAddress.Text = $"{_customInvoice.Company.Street} {_customInvoice.Company.HouseNumber}";
            txbInvoicePaid.Text = Convert.ToString(_customInvoice.PaidAt);
            nudHoursWorked.Value = (decimal)_customInvoice.HoursWorked;
            nudDiscount.Value = (decimal)_customInvoice.Discount;
            nudPricePerHour.Value = (decimal)_customInvoice.PricePerHour;
            txbNotes.Text = _customInvoice.Notes;

            if (_paymentTerm == "Maandelijks")
            {
                cbMonthly.Checked = true;
            }
            else if (_paymentTerm == "Jaarlijks")
            {
                cbYearly.Checked = true;
            }
        }

        private void btnBackToInvoiceOverview_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
