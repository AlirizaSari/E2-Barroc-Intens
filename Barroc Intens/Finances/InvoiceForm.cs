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

namespace Barroc_Intens.Finances
{
    public partial class InvoiceForm : Form
    {
        string _companyName = "";
        string _companyEmail = "";
        string _companyAdress = "";
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
            _companyName = txbCompanyName.Text;
            _companyEmail = txbEmailAdresCompany.Text;
            _companyAdress = txbCompanyAdress.Text;
            _comment = txbComment.Text;
            _date = dtpDate.Text.ToString();
            _hoursWorked = nudHoursWorked.Value;
            _discount = nudDiscount.Value;
            _pricePerHour = nudHourlyPrice.Value;


            if (stringInputValidation(_companyName) 
                && stringInputValidation(_companyAdress) 
                && stringInputValidation(_date)
                && decimalInputValidation(_hoursWorked)
                && decimalInputValidation(_pricePerHour)
                )
            {
                string message = $"hallo {_companyName},%0d%0a" +
                $"%0d%0aOp {_date} is er een koffiezetapparaat geïnstalleerd.%0d%0a" +
                $"Gelieve de volgende kosten zo snel mogelijk te betalen:%0d%0a%0d%0a" +
                $"Uur gewerkt%20|%20Arbeidskosten per uur%20|%20Korting%20|%20total%0d%0a";

                if (_discount > 0 && _discount <= 100)
                {
                    message += $"{_hoursWorked}%20|%20{_pricePerHour}%20|%20{_discount}%20|%20{_hoursWorked * _pricePerHour * (1 - (_discount / 100))}";
                }
                else
                {
                    message += $"{_hoursWorked}%20|%20{_pricePerHour}%20|%20{_discount}%20|%20{_hoursWorked * _pricePerHour * 1}";
                }

                if (!String.IsNullOrEmpty(_comment))
                {
                    message += $"%0d%0a{_comment}%0d%0a";
                }

                message += $"%0d%0aMet vriendelijke groeten,%0d%0a" +
                    $"Barroc Intens%0d%0a";

                Process.Start($"mailto:{_companyEmail}?subject=Factuur%20Installatie%20{_date.ToString()}&body={message}");

            }
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
                lblError.Text = "Zorg ervoor dat alle velden zijn ingevuld";
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
            DirectToForm(new MainForm());
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
    }
}
