using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Barroc_Intens
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public bool IsEmployeeOnly { get; set; }

        public ObservableCollectionListSource<Product> Products { get; } = new ObservableCollectionListSource<Product>();

        public override string ToString()
        {
            return this.Name;
        }
    }
}
