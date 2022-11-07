using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens.Classes
{
    static class SaveInfo
    {
        private static string companyName;
        public static string CompanyName { 
            get { return companyName; }
            set { companyName = value; }
        }

        private static string companyEmail;
        public static string CompanyEmail { 
            get { return companyEmail; } 
            set { companyEmail = value; } 
        }

        private static string companyAddress;
        public static string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; } 
        }

        private static string notes;
        public static string Notes
        {
            get { return Notes; }
            set { notes = value; }
        }

        private static double hoursWorked;
        public static double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        private static double discount;
        public static double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private static double pricePerHour;
        public static double PricePerHour
        {
            get { return pricePerHour; }
            set { pricePerHour = value; }
        }

        private static DateTime invoicePaidAt;
        public static DateTime InvoicePaidAt
        {
            get { return invoicePaidAt; }
            set { invoicePaidAt = value; }
        }

        private static DateTime createDate;
        public static DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }


    }
}
