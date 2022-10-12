using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Barroc_Intens.Classes
{
    internal class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int IsEmployeeOnly { get; set; }

        public ObservableCollectionListSource<Product> Products { get; } = new ObservableCollectionListSource<Product>();
    }
}
