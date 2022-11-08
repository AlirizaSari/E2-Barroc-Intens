using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Brand { get; set; }

        public string ImagePath { get; set; }

        public decimal? Price { get; set; }

        public int? AmountInStock { get; set; }

        public string StockStatus { get; set; }
        public int? OrderAmount { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null;

        public ObservableCollectionListSource<CustomInvoiceProduct> CustomInvoiceProducts { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();
    }
}
