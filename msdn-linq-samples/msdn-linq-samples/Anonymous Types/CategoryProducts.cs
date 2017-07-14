using System.Linq;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.Anonymous_Types
{
    public class CategoryProducts
    {
        public string Category { get; set; }

        public IGrouping<string, Product> Products { get; set; }
    }
}
