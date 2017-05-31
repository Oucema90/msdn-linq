using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples
{
    public class Class1
    {
        public static IEnumerable<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product("Chef Anton\'s Gumbo Mix", 0, 2M),
                new Product("Alice Mutton", 0, 7M),
                new Product("Thringer", 0, 6M),
                new Product("Gorgonzola", 0, 3M),
                new Product("Perth Pasties", 0, 1M),
                new Product("Chai", 3, 4M),
                new Product("Chang", 4, 5M),
                new Product("Aniseed Syrup", 3, 7M),
                new Product("Northwoods Cranberry Sauce", 2, 9M),
                new Product("Mishi Kobe Niku", 1, 11M),
            };
            
        }
    }
}
