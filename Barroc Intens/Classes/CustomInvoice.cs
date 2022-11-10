using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    public class CustomInvoice
    {
        public int CustomInvoiceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PaidAt { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; } 
        public double HoursWorked { get; set; }
        public double Discount { get; set; }
        public double PricePerHour { get; set; }
        public string Notes { get; set; }
        public string PaymentTerm { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ObservableCollectionListSource<CustomInvoiceProduct> CustomInvoiceProducts { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();

        public string CompanyEmailAddress
        {
            get { return Company.EmailAddress; }
        }

        public string CompanyCity
        {
            get { return Company.City; }
        }
        public string CompanyStreet
        {
            get { return Company.Street; }
        }

        public string CompanyHouseNumber
        {
            get { return Company.HouseNumber; }
        }

        public string ProductName
        {
            get { return Product.Name; }
        }
    }
}
