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
        public string CompanyEmail { get; set; }
        public string CompanyAdress { get; set; }
        public double HoursWorked { get; set; }
        public double Discount { get; set; }
        public double PricePerHour { get; set; }
        public string Notes { get; set; }
        public string PaymentTerm { get; set; }

        public ObservableCollectionListSource<CustomInvoiceProduct> CustomInvoiceProducts { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();

    }
}
