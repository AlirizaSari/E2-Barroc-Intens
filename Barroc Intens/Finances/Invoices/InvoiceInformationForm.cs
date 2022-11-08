﻿using Barroc_Intens.Classes;
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

        public InvoiceInformationForm(string companyName, 
            string invoicePaidAt, 
            string companyEmail,
            string companyAddress,
            double hoursWorked,
            double discount,
            double pricePerHour,
            string notes,
            string paymentTerm)
        {
            InitializeComponent();
            _companyName = companyName;
            _companyEmail = companyEmail;
            _companyAddress = companyAddress;
            _hoursWorked = hoursWorked;
            _discount = discount;
            _pricePerHour = pricePerHour;
            _notes = notes;
            _invoicePaidAt = invoicePaidAt;
            _paymentTerm = paymentTerm;
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