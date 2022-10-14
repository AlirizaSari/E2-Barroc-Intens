using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    internal class CustomInvoiceProduct
    {
        public int CustomInvoiceProductId { get; set; }
        public int CustomInvoiceId { get; set; }
        public CustomInvoice CustomInvoice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal PricePerProduct { get; set; }
    }
}
