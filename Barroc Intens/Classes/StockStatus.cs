using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    public class StockStatus
    {
        public int StockStatusId { get; set; }

        public string Name { get; set; }

        public ObservableCollectionListSource<Product> Products { get; } = new ObservableCollectionListSource<Product>();

        public override string ToString()
        {
            return this.Name;
        }
    }

}
