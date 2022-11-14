using Barroc_Intens.Classes;
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

namespace Barroc_Intens.Finances
{
    public partial class InvoiceInformationForm : Form
    {
        private AppDbContext dbContext;
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
            this.dbContext = new AppDbContext();


            //Because there is another dbContext, this has no influence on _customInvoice because that is from that other dbContext.
            //this.dbContext.CustomInvoices.Where(ci => ci.CustomInvoiceId == _customInvoice.CustomInvoiceId)
            //    .Include(ci => ci.Product)
            //    .Load();



            txbCompany.Text = _customInvoice.Company.Name;
            txbProduct.Text = _customInvoice.Product.Name;
            txbCompanyEmail.Text = _customInvoice.Company.EmailAddress;
            txbCompanyAddress.Text = $"{_customInvoice.Company.Street} {_customInvoice.Company.HouseNumber}";
            txbInvoicePaid.Text = Convert.ToString(_customInvoice.PaidAt);
            nudHoursWorked.Value = (decimal)_customInvoice.HoursWorked;
            nudDiscount.Value = (decimal)_customInvoice.Discount;
            nudPricePerHour.Value = (decimal)_customInvoice.PricePerHour;
            txbNotes.Text = _customInvoice.Notes;

            if (_customInvoice.PaymentTerm == "Maandelijks")
            {
                cbMonthly.Checked = true;
            }
            else if (_customInvoice.PaymentTerm == "Jaarlijks")
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
