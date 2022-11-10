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
        string _companyEmail;
        string _companyAddress;
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
            _companyName = chosenInvoice.Company.ToString();
            //_companyEmail = chosenInvoice.CompanyEmail;
            //_companyAddress = chosenInvoice.CompanyAdress;
            _hoursWorked = chosenInvoice.HoursWorked;
            _discount = chosenInvoice.Discount;
            _pricePerHour = chosenInvoice.PricePerHour;
            _notes = chosenInvoice.Notes;
            _invoicePaidAt = Convert.ToString(chosenInvoice.PaidAt);
            _paymentTerm = chosenInvoice.PaymentTerm;
            _customInvoice = chosenInvoice;
        }

        private void InvoiceInformationForm_Load(object sender, EventArgs e)
        {
            txbCompany.Text = _companyName;
            txbCompanyEmail.Text = _companyEmail;
            txbCompanyAddress.Text = _companyAddress;
            txbInvoicePaid.Text = _invoicePaidAt;
            nudHoursWorked.Value = (decimal)_hoursWorked;
            nudDiscount.Value = (decimal)_discount;
            nudPricePerHour.Value = (decimal)_pricePerHour;
            txbNotes.Text = _notes;

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
