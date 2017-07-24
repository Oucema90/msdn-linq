using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.Anonymous_Types
{
    public class CategoryProducts
    {
        public string Category { get; set; }

        public IGrouping<string, Product> Products { get; set; }

        public int ProductCount { get; set; }

        public int TotalUnitsInStock { get; set; }

        public decimal CheapestPrice { get; set; }

        public decimal MostExpensivePrice { get; set; }

        public decimal AveragePrice { get; set; }

        public IEnumerable<Product> CheapestProducts { get; set; }

        public IEnumerable<Product> MostExpensiveProducts { get; set; }
    }
}
