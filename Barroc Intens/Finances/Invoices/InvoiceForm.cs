using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;

namespace Barroc_Intens.Finances
{
    public partial class InvoiceForm : Form
    {
        private AppDbContext dbContext;

        string _companyName = "";
        string _companyEmail = "";
        string _companyAdress = "";
        string _comment;
        string _paymentTerm;
        string _message;
        DateTime _date;
        decimal _hoursWorked;
        decimal _discount;
        decimal _pricePerHour;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if (generateInvoice())
            {
                Process.Start($"mailto:{_companyEmail}?subject=Factuur%20Installatie%20{_date.ToString()}&body={_message}");
            }

        }

        private bool generateInvoice()
        {
            _companyName = cboxCompanyName.Text;
            _companyEmail = txbEmailAdresCompany.Text;
            _companyAdress = txbCompanyAdress.Text;
            _comment = txbComment.Text;
            _date = dtpDate.Value;
            _hoursWorked = nudHoursWorked.Value;
            _discount = nudDiscount.Value;
            _pricePerHour = nudHourlyPrice.Value;

            if (cbMonthly.Checked)
            {
                _paymentTerm = "Maandelijks";
            }
            else if (cbYearly.Checked)
            {
                _paymentTerm = "Jaarlijks";
            }

            if (stringInputValidation(_companyName)
                && stringInputValidation(_companyAdress)
                && decimalInputValidation(_hoursWorked)
                && decimalInputValidation(_pricePerHour)
                && stringInputValidation(_paymentTerm))
            {
                _message = $"Hallo {_companyName},%0d%0a" +
                $"%0d%0aOp {_date} is er een koffiezetapparaat geïnstalleerd.%0d%0a" +
                $"Het model koffiezetapparaat is: {cboxProduct.SelectedItem}%0d%0a" +
                $"%0d%0aGelieve de volgende kosten zo snel mogelijk te betalen:%0d%0a%0d%0a" +
                $"Uur gewerkt:%20{_hoursWorked} uur%0d%0a" +
                $"Arbeidskosten per uur: €{_pricePerHour}%0d%0a" +
                $"Korting: {Math.Round(_discount,2)}%%0d%0a";

                if (_discount > 0 && _discount <= 100)
                {
                    _message += $"Totaal €{Math.Round(_hoursWorked * _pricePerHour * (1 - (_discount / 100)),2)}%0d%0a";
                }
                else
                {
                    _message += $"Totaal €{Math.Round(_hoursWorked * _pricePerHour * 1, 2)}%0d%0a";
                }

                if (!String.IsNullOrEmpty(_comment))
                {
                    _message += $"%0d%0a{_comment}%0d%0a";
                }
                _message += $"%0d%0aUw betaaltermijn is: {_paymentTerm}%0d%0a";

                _message += $"%0d%0aMet vriendelijke groeten,%0d%0a" +
                    $"Barroc Intens%0d%0a%0d%0a";

                lblError.Text = "";

                return true;
            }
            return false;

        }

        /// <summary>
        /// Responsible for checking if an inputfield contains information.
        /// <br>In case it doesn't it gives an error.</br>
        /// </summary>
        /// <param name="companyInformation"></param>
        /// <returns></returns>
        private bool stringInputValidation(string companyInformation)
        {
            if (companyInformation == null)
            {
                lblError.Text = "Zorg ervoor dat alle velden ingevuld zijn";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Responsible for checking if an numericUpDown contains information.
        /// <br>In case it doesn't it gives an error.</br>
        /// </summary>
        /// <param name="companyInformation"></param>
        /// <returns></returns>
        private bool decimalInputValidation(decimal invoiceInformation)
        {
            if (invoiceInformation == 0)
            {
                lblError.Text = "Zorg ervoor dat alle velden zijn ingevuld";
                return false;
            }
            return true;
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void btnDirectToFinanceDash_Click(object sender, EventArgs e)
        {
            DirectToForm(new DashboardFinanceForm());
        }

        private void DirectToForm(Form myForm)
        {
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            this.dbContext.Companies.OrderBy(c => c.Name).Load();
            this.dbContext.Products.Where(pr => pr.CategoryId == 1).Load();

            this.companyBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

            GetDatabaseInfo();
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            if (generateInvoice())
            {
                var invoice = new CustomInvoice
                {
                    Date = dtpDate.Value,
                    HoursWorked = (double)nudHoursWorked.Value,
                    Discount = (double)nudDiscount.Value,
                    PricePerHour = (double)nudHourlyPrice.Value,
                    Notes = txbComment.Text,
                    PaymentTerm = _paymentTerm,

                    ProductId = (int)cboxProduct.SelectedValue,
                    CompanyId = (int)cboxCompanyName.SelectedValue
                };
                dbContext.CustomInvoices.Add(invoice);
            }

            dbContext.SaveChanges();
        }

        private void cboxCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDatabaseInfo();
             
        }

        private void GetDatabaseInfo()
        {
            if (this.dbContext == null)
                return;

            var company = (Company)cboxCompanyName.SelectedItem;
            //txbEmailAdresCompany.Text = 
            txbCompanyAdress.Text = $"{company.Street} {company.HouseNumber}";
            txbEmailAdresCompany.Text = company.EmailAddress;

            if (company == null)
                return;

            var isBkrChecked = company.IsBkrChecked;
            if (isBkrChecked)
            {
                cbBkrCheck.Checked = true;
            }
            else
            {
                cbBkrCheck.Checked = false;
            }
        }

        
        private void cbYearly_Click(object sender, EventArgs e)
        {
            cbMonthly.Checked = false;
        }

        private void cbMonthly_Click(object sender, EventArgs e)
        {
            cbYearly.Checked = false;
        }
    }
}
